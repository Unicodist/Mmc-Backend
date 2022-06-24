using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Core.Services.Blog;

public class BlogService : IBlogService
{
    private readonly IArticleRepository _articleRepository;
    private readonly IBlogUserRepository _blogUserRepository;
    private readonly ICategoryRepository _categoryRepository;

    public BlogService(IArticleRepository articleRepository, IBlogUserRepository blogUserRepository, ICategoryRepository categoryRepository)
    {
        _articleRepository = articleRepository;
        _blogUserRepository = blogUserRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task<IArticle> Create(ArticleCreateDto dto)
    {
        var admin = await _blogUserRepository.GetByIdAsync(dto.UserId);
        var category = await _categoryRepository.GetByGuid(dto.CategoryGuid);
        var blogpost = new Article(dto.Title,dto.Body,DateOnly.FromDateTime(DateTime.Now), category,admin,dto.Thumbnail);
        await _articleRepository.InsertAsync(blogpost);
        return blogpost;
    }

    public async Task Update(ArticleUpdateDto dto)
    {
        var blog = await _articleRepository.GetByIdAsync(dto.Id) ?? throw new ArticleNotFoundException();
        var category = await _categoryRepository.GetByGuid(dto.CategoryGuid).ConfigureAwait(false);
        blog.Update(dto.Title, dto.Body, category);
    }

    public async Task SubmitUpvote(LikeDto likeDto)
    {
        var article = await _articleRepository.GetByIdAsync(likeDto.ArticleId)??throw new ArticleNotFoundException();
        var user = await _blogUserRepository.GetByIdAsync(likeDto.UserId)??throw new UserNotFoundException();
        
        
    }

    private void ValidateForSpam(ArticleCreateDto dto)
    {
        var posts = _articleRepository.GetQueryable().Where(a => a.User.Id == dto.UserId);
        _ = posts.Select(x =>
            x.PostedDate == DateOnly.FromDateTime(DateTime.Now) &&
            (x.PostedTime - TimeOnly.FromDateTime(DateTime.Now)) < TimeSpan.FromMinutes(20));
    }
}
