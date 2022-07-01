using Mechi.Backend.Helper;
using Mechi.Backend.ViewModel.Notice;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Repository;

namespace Mechi.Backend.Controllers.Core;

public class NotificationController : Controller
{
    private readonly INotificationRepository _notificationRepository;

    // GET
    public NotificationController(INotificationRepository notificationRepository, IBlogUserRepository userRepository)
    {
        _notificationRepository = notificationRepository;
        UserHelper.BlogUserRepository = userRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Read(GridQueryModel model)
    {
        var notifications = await _notificationRepository.GetAllAsync();
        var userRole = User.GetRole();
        var user = this.GetCurrentBlogUser();
        if (userRole!="Superuser")
        {
            notifications = notifications.Where(x => x.UserType == userRole || user.Id == x.Id).ToList();
        }
        var returnModel = notifications.Select(x => new
        {
            ArticleGuid = x.Article.Guid,
            x.Body,
            Date = x.Date.ToString(),
        }).ToList();
        return Ok(model.Fill(returnModel));
    }
}
