using Mechi.Backend.ApiModel.Notice;
using Mechi.Backend.ViewModel.Notice;
using Microsoft.AspNetCore.Mvc;
using Mmc.Notice.Enum;
using Mmc.Notice.Repository;
using Mmc.Notice.Service.Interface;

namespace Mechi.Backend.Controllers.GridControllers;
public class NoticeGridController : ControllerBase
{
    private readonly INoticeRepository _noticeRepository;
    private INoticeService _noticeService;

    public NoticeGridController(INoticeRepository noticeRepository, INoticeService noticeService)
    {
        _noticeRepository = noticeRepository;
        _noticeService = noticeService;
    }
    [HttpGet]
    public Task<IActionResult> Read(NoticeGridQueryModel model)
    {
        var noticeMasters = _noticeRepository.GetQueryable().Where(x=>x.Status==Status.Active.ToString());
        if (model.current > 1)
        {
            noticeMasters = noticeMasters.Skip((model.current - 1)*10);
        }
        noticeMasters = noticeMasters.Take(model.rowCount);
        model.total = noticeMasters.Count();
        var result = noticeMasters.Select(x => new NoticeResponseApiModel
        {
            Guid = x.Guid.ToString(),
            Title = x.Title,
            Body = x.Body,
            Date = DateOnly.FromDateTime(x.PostedOn).ToString(),
            Picture = x.Picture
        }).ToList();
        result.Reverse();
        return Task.FromResult<IActionResult>(Ok(model.Fill(result)));
    }
}
