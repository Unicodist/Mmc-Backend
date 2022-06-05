using Mmc.Blog.Dto;
using Mmc.Blog.Entity.Interface;
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

    public async Task<IArticle> Create(ArticleCreateDto blogCreateDto)
    {
        var admin = await _blogUserRepository.GetBlogUserById(blogCreateDto.AdminId);
        var category = await _categoryRepository.GetById(blogCreateDto.CategoryId);
        var blogpost = _articleRepository.CreateInstance(blogCreateDto.Title,blogCreateDto.AuthorName,blogCreateDto.Body,blogCreateDto.PostedDate,admin,category);
        await _articleRepository.InsertAsync(blogpost);
        return blogpost;
    }

    public Task Update(BlogUpdateDto blogUpdateDto)
    {
        throw new NotImplementedException();
    }
}