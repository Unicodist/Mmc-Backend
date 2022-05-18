using Mmc.Blog.Entity;
using Mmc.Core.Dto;
using Mmc.Core.Repository;
using Mmc.Core.Services.Interface;

namespace Mmc.Core.Services;

public class BlogServices : BlogServiceInterface
{
    private IBlogPostRepository _blogPostRepository;
    public async Task Create(BlogCreateDto blogCreateDto)
    {
        var blogpost = _blogPostRepository.CreateInstance(blogCreateDto.Title,blogCreateDto.AuthorName,blogCreateDto.Body,blogCreateDto.PostedDate);
        await _blogPostRepository.Insert(blogpost);
    }

    public Task Update(BlogUpdateDto blogUpdateDto)
    {
        throw new NotImplementedException();
    }
}