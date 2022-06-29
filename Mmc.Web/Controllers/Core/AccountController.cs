using System.Security.Claims;
using Mechi.Backend.Helper;
using Mechi.Backend.ViewModel.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Repository;
using Mmc.User.Dto;
using Mmc.User.Repository;
using Mmc.User.Service;
using Mmc.User.ViewModel;

namespace Mechi.Backend.Controllers.Core;

public class AccountController : Controller
{
    private readonly IUserService _userServices;
    private readonly IUserUserRepository _userRepository;
    private readonly IArticleRepository _articleRepository;
    private readonly ICommentRepository _commentRepository;

    public AccountController(IUserService userServices, IUserUserRepository userRepository, IBlogUserRepository blogUserRepository, IArticleRepository articleRepository, ICommentRepository commentRepository)
    {
        _userServices = userServices;
        _userRepository = userRepository;
        _articleRepository = articleRepository;
        _commentRepository = commentRepository;
        UserHelper.BlogUserRepository = blogUserRepository;
    }
    [Route("/Profile/{username}")]
    [AllowAnonymous]
    public async Task<IActionResult> Index(string username)
    {
        var user = await _userRepository.GetByUsername(username);
        var thisUser = this.GetCurrentBlogUser();
        var articleCount = _articleRepository.GetQueryable().Count(x => x.UserId == user.Id);
        var commentCount = _commentRepository.GetQueryable().Count(x => x.UserId == user.Id);
        var model = new UserViewModel()
        {
            Name = user.Name,
            UserName = user.UserName,
            UserType = user.UserType.ToString(),
            Email = user.Email,
            Picture = user.Picture.Location,
            Campus = user.Organization.Name,
            CurrentUser = user.Id==thisUser.Id,
            ArticleCount = articleCount,
            CommentCount = commentCount
        };
        return View(model);
    }
    [Authorize]
    [Route("/Profile")]
    public async Task<IActionResult> Index()
    {
        var user = this.GetCurrentBlogUser();
        return await Index(user.UserName);
    }

    public IActionResult Edit(UserUpdateViewModel model)
    {
        return Ok();
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
    [Route("/logout")]
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
