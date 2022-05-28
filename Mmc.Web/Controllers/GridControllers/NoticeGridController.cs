using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ApiModel.Notice;
using Mmc.Core.Repository;
using Mmc.Notice.Repository;

namespace Mechi.Backend.Controllers.GridControllers;
[ApiController]
[Route("/grid/[controller]")]
public class NoticeGridController : ControllerBase
{
    private readonly NoticeRepositoryInterface _noticeRepository;
    
    public NoticeGridController(NoticeRepositoryInterface noticeRepository)
    {
        _noticeRepository = noticeRepository;
    }
    [HttpGet]
    public async Task<IActionResult> Read()
    {
        var noticeMasters = await _noticeRepository.GetAll();
        var result = noticeMasters.Select(x => new NoticeResponseApiModel()
        {
            Title = x.Title,
            Body = x.Body,
            Date = x.PostedOn.ToString(),
            Picture = x.Picture
        });
        return Ok(result);
    }
}