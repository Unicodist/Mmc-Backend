using Mmc.Blog.Entity;
using Mmc.Core.Dto;
using Mmc.Core.Repository;
using Mmc.Core.Services.Interface;

namespace Mmc.Core.Services;

public class BlogServices : BlogServiceInterface
{
    private BlogPostRepositoryInterface _blogPostRepository;
    public async Task Create(BlogCreateDto blogCreateDto)
    {
        BlogMasterEntity blog = new()
        {
            BlogMasterTitle = blogCreateDto.Title,
            BlogMasterAuthorAdminId = 1,
            BlogMasterAuthorName = blogCreateDto.AuthorName,
            BlogMasterBody = blogCreateDto.Body,
            BlogMasterPostedDate = blogCreateDto.PostedDate
        };
        await _blogPostRepository.Insert(blog);
    }

    public Task Update(BlogUpdateDto blogUpdateDto)
    {
        throw new NotImplementedException();
    }
}