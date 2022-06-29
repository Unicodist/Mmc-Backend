using Mechi.Backend.Helper;
using Mechi.Backend.ViewModel.Notice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Core.Repository;
using Mmc.Notice.Dto;
using Mmc.Notice.Enum;
using Mmc.Notice.Exception;
using Mmc.Notice.Repository;
using Mmc.Notice.Service.Interface;

namespace Mechi.Backend.Controllers.Notice;
public class NoticeController : Controller
{
    private readonly INoticeRepository _noticeRepository;
    private readonly ICourseRepository _courseRepository;
    private readonly INoticeService _noticeService;
    private IWebHostEnvironment _webHostEnvironment;

    public NoticeController(INoticeRepository noticeRepository, ICourseRepository courseRepository, INoticeService noticeService, INoticeUserRepository noticeUserRepository, IWebHostEnvironment webHostEnvironment)
    {
        _noticeRepository = noticeRepository;
        _courseRepository = courseRepository;
        _noticeService = noticeService;
        _webHostEnvironment = webHostEnvironment;
        UserHelper.NoticeUserRepository= noticeUserRepository;
    }

    public IActionResult Index()
    {
        return View();
    }
    [Authorize]
    public async Task<IActionResult> Create([FromForm]NoticeCreateViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);
        var courses = await _noticeRepository.GetAllAsync();
        if (model.CourseGuids!=null)
            courses = courses!.Where(x => model.CourseGuids.Contains(x.Guid)).ToList();
        var severity = BaseEnum.GetAll<NoticeSeverity>().SingleOrDefault(x => x.Id == model.SeverityId) ??
                       throw new UnknownSeverityLevelException();
        var image = await FileHandler.UploadFile(model.Image,_webHostEnvironment);
        var user = this.GetCurrentNoticeUser();
        var noticeCreateDto = new NoticeCreateDto(model.Title,model.Body,image,severity,user);
        await _noticeService.Create(noticeCreateDto);
        
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
