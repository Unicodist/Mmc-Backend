using Mmc.Notice.Dto;
using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Helper;
using Mmc.Notice.Repository;
using Mmc.Notice.Service.Interface;

namespace Mmc.Notice.Service;

public class NoticeService : INoticeService
{
    private readonly INoticeRepository _noticeRepository;
    public NoticeService(INoticeRepository noticeRepository)
    {
        _noticeRepository = noticeRepository;
    }

    public async Task<INotice> Create(NoticeCreateDto dto)
    {
        var notice = new Entity.Notice(dto.Title,dto.Body,dto.Picture,dto.Severity,dto.Author)
        {
            PostedOn = DateTime.Now
        };
        return await _noticeRepository.Insert(notice);
    }

    public void Update(NoticeUpdateDto noticeUpdateDto)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(string guid)
    {
        var tx = TransactionScopeHelper.GetInstance;
        var notice = await _noticeRepository.GetByGuidAsync(guid).ConfigureAwait(false);
        notice.Deactivate();
        await _noticeRepository.Update(notice);
        tx.Complete();
    }
}
