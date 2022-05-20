using Mmc.Blog.Dto;

namespace Mmc.Blog.Service.Interface;

public interface IBlogService
{
    public Task Create(BlogPostCreateDto blogCreateDto);
    public Task Update(BlogUpdateDto blogUpdateDto);
}