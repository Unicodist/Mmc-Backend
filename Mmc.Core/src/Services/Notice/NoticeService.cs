using Mmc.Core.Repository;
using Mmc.Notice.Dto;
using Mmc.Notice.Repository;
using Mmc.Notice.Service.Interface;

namespace Mmc.Core.Services.Notice;

public class NoticeService : INoticeService
{
    private NoticeRepositoryInterface _noticeRepository;
    public NoticeService(NoticeRepositoryInterface noticeRepository)
    {
        _noticeRepository = noticeRepository;
    }

    public Task Create(NoticeCreateDto noticeCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task Update(NoticeUpdateDto noticeUpdateDto)
    {
        throw new NotImplementedException();
    }
}