using System.Globalization;
using Mechi.Backend.ApiModel.Notice;
using Microsoft.AspNetCore.Mvc;
using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Repository;

namespace Mechi.Backend.Controllers.Api;

[ApiController]
public class NoticeApiController : ControllerBase
{
    private INoticeRepository _noticeRepository;

    public NoticeApiController(INoticeRepository noticeRepository)
    {
        _noticeRepository = noticeRepository;
    }
    [HttpGet]
    [Route("[controller]/Get")]
    public async Task<IActionResult> Get()
    {
        var noticeMasters = (await _noticeRepository.GetAllAsync())??new List<INotice>();
        var result = noticeMasters.Select(x => new NoticeResponseApiModel()
        {
            Title = x.Title,
            Body = x.Body,
            Date = x.PostedOn.ToString(CultureInfo.InvariantCulture),
            Picture = x.Picture
        });
        return Ok(result);
    }

    [HttpGet("[controller]/Get/{guid}")]
    public async Task<IActionResult> Get(string guid)
    {
        var noticeMaster = await _noticeRepository.GetByGuidAsync(guid);
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