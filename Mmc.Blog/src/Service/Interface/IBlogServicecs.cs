using Mmc.Blog.Dto;

namespace Mmc.Blog.Service.Interface;

public interface IBlogService
{
    public Task Create(ArticleCreateDto blogCreateDto);
    public Task Update(BlogUpdateDto blogUpdateDto);
}