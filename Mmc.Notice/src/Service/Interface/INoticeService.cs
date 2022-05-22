using Mmc.Notice.Dto;

namespace Mmc.Notice.Service.Interface;

public interface INoticeService
{
    public Task Create(NoticeCreateDto noticeCreateDto);
    public Task Update(NoticeUpdateDto noticeUpdateDto);
}