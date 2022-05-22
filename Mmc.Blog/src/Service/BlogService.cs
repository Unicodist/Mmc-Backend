using Mmc.Blog.Dto;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Core.Services;

public class BlogService : IBlogService
{
    private IBlogPostRepository _blogPostRepository;
    public async Task Create(ArticleCreateDto blogCreateDto)
    {
        var blogpost = _blogPostRepository.CreateInstance(blogCreateDto.Title,blogCreateDto.AuthorName,blogCreateDto.Body,blogCreateDto.PostedDate);
        await _blogPostRepository.Insert(blogpost);
    }

    public Task Update(BlogUpdateDto blogUpdateDto)
    {
        throw new NotImplementedException();
    }
}