using Mmc.Blog.BaseType;
using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Blog.Service;

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
        var admin = await _blogUserRepository.GetBlogUserById(dto.AdminId);
        var category = await _categoryRepository.GetByGuid(dto.CategoryGuid);
        var blogpost = new Article(dto.Title,dto.Body,DateTime.Now, category,admin,dto.Thumbnail);
        await _articleRepository.InsertAsync(blogpost);
        return blogpost;
    }

    public async Task Update(ArticleUpdateDto dto)
    {
        var blog = await _articleRepository.GetByIdAsync(dto.Id) ?? throw new ArticleNotFoundException();
        var category = await _categoryRepository.GetByGuid(dto.CategoryGuid).ConfigureAwait(false);
        blog.Update(dto.Title, dto.Body, category);
    }
}