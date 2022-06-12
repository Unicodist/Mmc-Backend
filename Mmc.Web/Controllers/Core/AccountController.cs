using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Core.Dto;
using Mmc.User.Dto;
using Mmc.User.Service;
using Mmc.User.ViewModel;

namespace Mechi.Backend.Controllers.Core;

public class AccountController : Controller
{
    private readonly IUserService _userServices;

    public AccountController(IUserService userServices)
    {
        _userServices = userServices;
    }
    [Authorize(Roles = "Superuser,Admin")]
    [Route("[controller]/Profile/{id}")]
    public IActionResult Index(long id)
    {
        return View();
    }
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Register(UserCreateViewModel model)
    {
        if(!ModelState.IsValid)
            return View(model);
        var userCreateDto = new UserCreateDto()
        {
            Name = model.FirstName+" "+model.LastName,
            Email = model.Email,
            Password = model.Password,
            Username = model.Username
        };
        _ = await _userServices.Create(userCreateDto);

        return RedirectToAction("Index", "Home");
    }

    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(UserLoginViewModel model)
    {
        if(!ModelState.IsValid)
            return View(model);
        var userLoginDto = new UserLoginDto
        {
            Password = model.Password,
            Username = model.Username
        };
        var user = _userServices.ValidateUser(userLoginDto);
        var claims = new List<Claim>()
        {
            new(ClaimTypes.Email,user.Email),
            new(ClaimTypes.Name,user.Name),
            new(ClaimTypes.NameIdentifier,user.UserName),
            new(ClaimTypes.Role,user.UserType),
        };
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principle = new ClaimsPrincipal(identity);
        await HttpContext.SignInAsync(principle);
        return RedirectToAction("Index","Dashboard");
    }
    public IActionResult Logout()
    {
        HttpContext.SignOutAsync();
        return RedirectToAction("Index","Home");
    }

    public IActionResult UnAuthorized()
    {
        return Ok("You are not authorized!");
    }
    
}