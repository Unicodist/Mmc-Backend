using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ApiModel.Notice;
using Mmc.Core.Repository;

namespace Mechi.Blog.GridControllers;
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
        var result = noticeMasters.Select(x => new NoticeReponseApiModel()
        {
            Title = x.NoticeMasterTitle,
            Body = x.NoticeMasterBody,
            Date = x.PostedOn.ToString(),
            Picture = x.NoticeMasterNoticePicture
        });
        return Ok(result);
    }
}