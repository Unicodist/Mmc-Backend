﻿using Microsoft.AspNetCore.Mvc;

namespace Mechi.Backend.Controllers.Core
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetDynamicPartialView()
        {
            var CurrentUser = User.Identity;
            if (CurrentUser.IsAuthenticated)
            {
                return PartialView("_Partial_Navigation_Menu_Logged_In");
            }

            return PartialView("_Partial_Navigation_Non_Logged");
        }
    }
}
