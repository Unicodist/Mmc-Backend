using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.User.Dto;
using Mmc.User.Repository;
using Mmc.User.Service;
using Mmc.User.ViewModel;

namespace Mechi.Backend.Controllers.Core;

public class AccountController : Controller
{
    private readonly IUserService _userServices;
    private readonly IUserUserRepository _userRepository;

    public AccountController(IUserService userServices, IUserUserRepository userRepository)
    {
        _userServices = userServices;
        _userRepository = userRepository;
    }
    [Route("[controller]/{username}")]
    public async Task<IActionResult> Index(string username)
    {
        var user = await _userRepository.GetByUsername(username);
        return View();
    }
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }

    [Route("/Register")]
    public async Task<IActionResult> Register(UserCreateViewModel? model)
    {
        if (!ModelState.IsValid)
            return View(model);
        var userCreateDto = new UserCreateDto
        {
            Name = model.FirstName + " " + model.LastName,
            Email = model.Email,
            Password = model.Password,
            Username = model.Username,
            CampusGuid = model.CollegeGuid
        };
        _ = await _userServices.Create(userCreateDto);

        return RedirectToAction("Index", "Home");
    }

    [AllowAnonymous]
    [Route("/Login")]
    public async Task<IActionResult> Login(UserLoginViewModel model)
    {
        if(!ModelState.IsValid)
            return View(model);
        var userLoginDto = new UserLoginDto
        {
            Password = model.Password,
            Username = model.Username
        };
        var user = await _userServices.ValidateUser(userLoginDto);
        var claims = new List<Claim>
        {
            new(ClaimTypes.Email,user.Email),
            new(ClaimTypes.Name,user.Name),
            new(ClaimTypes.NameIdentifier,user.UserName),
            new(ClaimTypes.Role,user.UserType)
        };
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principle = new ClaimsPrincipal(identity);
        await HttpContext.SignInAsync(principle);
        if (string.IsNullOrEmpty(model.ReturnUrl))
        {
            return RedirectToAction("Index","Dashboard");
        }
        return Redirect(model.ReturnUrl);
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
