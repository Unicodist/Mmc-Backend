using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ViewModel;
using Mmc.Core.Dto;
using Mmc.Core.Enum;
using Mmc.Core.Repository;
using Mmc.Core.Services;
using Mmc.Data;
using Mmc.User.Entity;

namespace Mmc.Backend.Controllers;

public class LoginController : Controller
{
    private readonly UserRepositoryInterface _userRepositoryInterface;
    private readonly UserServices _userServices;
    public IActionResult Index()
    {
        return View();
    }

    public Task Login(UserSignUpModel model)
    {
        UserCreateDto userCreateDto = new()
        {
            Name = model.FirstName + " " + model.LastName,
            Email = model.Email,
            Password = model.Password,
            UserType = UserType.USER
        };

        _userServices.Create(userCreateDto);

        return Task.CompletedTask;
    }
}