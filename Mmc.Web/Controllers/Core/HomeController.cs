using System.Security.Claims;
using Mechi.Backend.ViewModel.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers.Core
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetDynamicNavbar()
        {
            var claimsPrincipal = User;
            switch (claimsPrincipal.Identity!.IsAuthenticated)
            {
                case true:
                {
                    var role = claimsPrincipal.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)!.Value;
                    return role is "Superuser" or "Admin" or "Mod" ? PartialView("_Partial_Navigation_Logged_Admin",new NavbarViewModel {NotificationCount = "0"}) : PartialView("_Partial_Navigation_Menu_Logged_In",new NavbarViewModel {NotificationCount = "2"});
                }
                default:
                    return PartialView("_Partial_Navigation_Non_Logged");
            }
        }
    }
}
