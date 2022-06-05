using Mmc.Notice.Dto;

namespace Mmc.Notice.Service.Interface;

public interface INoticeService
{
    public void Create(NoticeCreateDto noticeCreateDto);
    public void Update(NoticeUpdateDto noticeUpdateDto);
}