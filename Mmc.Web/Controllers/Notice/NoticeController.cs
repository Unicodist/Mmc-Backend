using Microsoft.AspNetCore.Mvc;
using Mmc.Notice.Repository;
using Mmc.Notice.ViewModel;

namespace Mechi.Backend.Controllers.Notice;
public class NoticeController : Controller
{
    private NoticeRepositoryInterface _noticeRepository;

    public NoticeController(NoticeRepositoryInterface noticeRepository)
    {
        _noticeRepository = noticeRepository;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    public async Task<IActionResult> Read()
    {
        var notices = await _noticeRepository.GetAllAsync();
        var noticeModel = notices.Select(x => new NoticeViewModel()
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