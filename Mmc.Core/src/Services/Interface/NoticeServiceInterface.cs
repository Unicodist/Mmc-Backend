using Mmc.Core.Dto;
using Mmc.Notice.Dto;

namespace Mmc.Core.Services.Interface;

public interface NoticeServiceInterface
{
    public Task Create(NoticeCreateDto noticeCreateDto);
    public Task Update(NoticeUpdateDto noticeUpdateDto);
}