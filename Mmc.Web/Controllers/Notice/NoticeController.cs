using Mechi.Backend.ViewModel.Notice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Core.Repository;
using Mmc.Notice.Repository;

namespace Mechi.Backend.Controllers.Notice;
public class NoticeController : Controller
{
    private INoticeRepository _noticeRepository;
    private readonly ICourseRepository _courseRepository;

    public NoticeController(INoticeRepository noticeRepository, ICourseRepository courseRepository)
    {
        _noticeRepository = noticeRepository;
        _courseRepository = courseRepository;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }
    [Authorize]
    public async Task<IActionResult> Create(NoticeCreateViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var courses = await _courseRepository.FindBy(x => model.CourseGuids.Contains(x.Guid.ToString()));
        
        
        return RedirectToAction("Index");
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
