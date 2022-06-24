using Mechi.Backend.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Dto;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mechi.Backend.Controllers.Api;

public class LikeApiController : Controller
{
    private readonly IArticleRepository _articleRepository;
    private readonly IBlogService _articleService;
    private readonly IUpvoteRepository _upvoteRepository;

    public LikeApiController(IArticleRepository articleRepository, IBlogService articleService, IUpvoteRepository upvoteRepository)
    {
        _articleRepository = articleRepository;
        _articleService = articleService;
        _upvoteRepository = upvoteRepository;
    }
    
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> SubmitLike(string guid)
    {
        var user = this.GetCurrentBlogUser();
        var article = await _articleRepository.GetByGuidAsync(guid);
        if (article.Likes.Select(x=>x.UserId).Contains(user.Id))
        {
            return Problem("Duplicate like","This",500,"The article is already liked");
        }

        var likeDto = new LikeDto(user.Id,article.Id);
        await _articleService.SubmitUpvote(likeDto);

        var like = await _upvoteRepository.GetByUserIdAndArticleId(user.Id, article.Id);
        return Ok(like==null ? new {Liked = true} : new {Liked = false});
    }

    public async Task<IActionResult> RemoveLike(string guid)
    {
        var user = this.GetCurrentBlogUser();
        var article = await _articleRepository.GetByGuidAsync(guid);
        return Ok();
    }
}
