using Mmc.Notice.Dto;
using Mmc.Notice.Entity.Interface;

namespace Mmc.Notice.Service.Interface;

public interface INoticeService
{
    public Task<INotice> Create(NoticeCreateDto dto);
    public void Update(NoticeUpdateDto noticeUpdateDto);
    Task Delete(string guid);
}
