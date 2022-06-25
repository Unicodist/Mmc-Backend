using Mechi.Backend.ViewModel.Notice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Notice.Repository;

namespace Mechi.Backend.Controllers.Notice;
public class NoticeController : Controller
{
    private INoticeRepository _noticeRepository;

    public NoticeController(INoticeRepository noticeRepository)
    {
        _noticeRepository = noticeRepository;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }
    [Authorize]
    public IActionResult Create(NoticeCreateViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        return View();
    }

    public async Task<IActionResult> Read()
    {
        var notices = await _noticeRepository.GetAllAsync();
        var noticeModel = notices.Select(x => new NoticeViewModel
        {
            Guid = x.Guid.ToString(),
            Title = x.Title,
            Body = x.Body,
            Date = x.PostedOn,
            Image = x.Picture,
            User = x.Author.Name
        });
        return Json(noticeModel);
    }
}
