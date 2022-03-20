using Mmc.Core.Dto;

namespace Mmc.Core.Services.Interface;

public interface BlogServiceInterface
{
    public Task Create(BlogCreateDto blogCreateDto);
    public Task Update(BlogUpdateDto blogUpdateDto);
}