using Mmc.Core.Dto;
using Mmc.Core.Repository;
using Mmc.Core.Services.Interface;
using Mmc.Notice.Dto;
using Mmc.Notice.Entity;

namespace Mmc.Core.Services;

public class NoticeServices : NoticeServiceInterface
{
    private NoticeRepositoryInterface _noticeRepository;
    public NoticeServices(NoticeRepositoryInterface noticeRepository)
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