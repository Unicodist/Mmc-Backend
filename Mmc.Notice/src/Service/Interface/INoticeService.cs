using Mmc.Notice.Dto;

namespace Mmc.Notice.Service.Interface;

public interface INoticeService
{
    public void Create(NoticeCreateDto dto);
    public void Update(NoticeUpdateDto noticeUpdateDto);
    Task Delete(string guid);
}
