using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ViewModel;
using Mmc.Core.Dto;
using Mmc.Core.Services.Interface;

namespace Mechi.Backend.Controllers;

public class LoginController : Controller
{
    private readonly UserServiceInterface _userServices;

    public LoginController(UserServiceInterface userServices)
    {
        _userServices = userServices;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
    public Task CreateAction(UserSignUpModel model)
    {
        UserCreateDto userCreateDto = new()
        {
            Name = model.FirstName + " " + model.LastName,
            Email = model.Email,
            Password = model.Password
        };

        _userServices.Create(userCreateDto);

        return Task.CompletedTask;
    }

    public IActionResult LoginAction()
    {
        return Ok();
    }
}