using Mmc.Blog.Dto;
using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Service.Interface;

public interface IBlogService
{
    public Task<IArticle> Create(ArticleCreateDto dto);
    public Task Update(ArticleUpdateDto dto);
    Task SubmitUpvote(LikeDto likeDto);
}
