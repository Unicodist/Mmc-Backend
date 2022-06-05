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

        public IActionResult GetDynamicPartialView()
        {
            if (User.Identity!.IsAuthenticated)
            {
                return PartialView("_Partial_Navigation_Menu_Logged_In",new NavbarViewModel(){NotificationCount = "2"});
            }
            
            return PartialView("_Partial_Navigation_Non_Logged");
        }
    }
}
