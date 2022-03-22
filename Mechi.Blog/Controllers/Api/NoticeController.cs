using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mmc.Api.Dto;
using Mmc.Core.Repository;
using Mmc.Notice.Entity;

namespace Mmc.Blog.Api;

[ApiController]
[Route("api/[controller]")]
public class NoticeController : ControllerBase
{
    private NoticeRepositoryInterface _noticeRepository;

    public NoticeController(NoticeRepositoryInterface noticeRepository)
    {
        _noticeRepository = noticeRepository;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var noticeMasters = await _noticeRepository.GetAll();
        var result = noticeMasters.Select(x => new NoticeMasterResponseApiModel()
        {
            Title = x.NoticeMasterTitle,
            Body = x.NoticeMasterBody,
            Date = x.PostedOn.ToString(),
            Picture = x.NoticeMasterNoticePicture
        });
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        var noticeMaster = await _noticeRepository.GetById(id);
        var result = new NoticeMasterResponseApiModel()
        {
            Title = noticeMaster.NoticeMasterTitle,
            Body = noticeMaster.NoticeMasterBody,
            Date = noticeMaster.PostedOn.ToString(),
            Picture = noticeMaster.NoticeMasterNoticePicture
        };
        return Ok(result);
    }
}