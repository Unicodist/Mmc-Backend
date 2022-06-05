using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ApiModel.Notice;
using Mmc.Core.Repository;
using Mmc.Notice.Repository;

namespace Mmc.Blog.Api;

[ApiController]
[Route("api/[controller]")]
public class NoticeApiController : ControllerBase
{
    private NoticeRepositoryInterface _noticeRepository;

    public NoticeApiController(NoticeRepositoryInterface noticeRepository)
    {
        _noticeRepository = noticeRepository;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var noticeMasters = await _noticeRepository.GetAllAsync();
        var result = noticeMasters.Select(x => new NoticeResponseApiModel()
        {
            Title = x.Title,
            Body = x.Body,
            Date = x.PostedOn.ToString(),
            Picture = x.Picture
        });
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        var noticeMaster = await _noticeRepository.GetByIdAsync(id);
        var result = new NoticeResponseApiModel()
        {
            Title = noticeMaster.Title,
            Body = noticeMaster.Body,
            Date = noticeMaster.PostedOn.ToString(),
            Picture = noticeMaster.Picture
        };
        return Ok(result);
    }
}