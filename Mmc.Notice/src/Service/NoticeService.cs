using Mmc.Notice.Dto;
using Mmc.Notice.Repository;
using Mmc.Notice.Service.Interface;

namespace Mmc.Notice.Service;

public class NoticeService : INoticeService
{
    private readonly NoticeRepositoryInterface _noticeRepository;
    public NoticeService(NoticeRepositoryInterface noticeRepository)
    {
        _noticeRepository = noticeRepository;
    }

    public void Create(NoticeCreateDto noticeCreateDto)
    {
        var notice = new Entity.Notice(noticeCreateDto.Title,noticeCreateDto.Body,noticeCreateDto.Picture,noticeCreateDto.Author)
        {
            PostedOn = DateTime.Now
        };
        _noticeRepository.Insert(notice);
    }

    public void Update(NoticeUpdateDto noticeUpdateDto)
    {
        throw new NotImplementedException();
    }
}