using Mechi.Backend.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Dto;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mechi.Backend.Controllers.Api;

public class HeartApiController : Controller
{
    private readonly IArticleRepository _articleRepository;
    private readonly IBlogService _articleService;
    private readonly IHeartRepository _heartRepository;
    private readonly IHeartService _heartService;

    public HeartApiController(IArticleRepository articleRepository, IBlogService articleService, IHeartRepository heartRepository, IHeartService heartService)
    {
        _articleRepository = articleRepository;
        _articleService = articleService;
        _heartRepository = heartRepository;
        _heartService = heartService;
    }
    
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Heart(string guid)
    {
        var user = this.GetCurrentBlogUser();
        var article = await _articleRepository.GetByGuidAsync(guid);
        if (article.Likes.Select(x=>x.UserId).Contains(user.Id))
        {
            return Problem("Duplicate like","This",500,"The article is already liked");
        }

        var heartDto = new HeartDto(user.Id,article.Guid);
        await _heartService.Heart(heartDto);

        var like = await _heartRepository.GetByUserIdAndArticleId(user.Id, article.Id);
        return Ok(like==null ? new {Liked = true} : new {Liked = false});
    }

    public async Task<IActionResult> RemoveLike(string guid)
    {
        var user = this.GetCurrentBlogUser();
        var article = await _articleRepository.GetByGuidAsync(guid);
        return Ok();
    }
}
