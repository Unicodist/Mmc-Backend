using Mechi.Backend.Helper;
using Mechi.Backend.ViewModel.Notice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.User.Enum;
using Mmc.User.Repository;
using Mmc.User.UserException;

namespace Mechi.Backend.Controllers.Api;

public class UserApiController : Controller
{
    private readonly IUserUserRepository _userRepository;

    public UserApiController(IUserUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> MakeUser([FromForm]string username)
    {
        return await ChangeUserType(username, UserType.USER);
    }
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> MakeStaff([FromForm]string username)
    {
        return await ChangeUserType(username, UserType.ADMIN);
    }
    [Authorize]
    private async Task<IActionResult> ChangeUserType(string guid, UserType type)
    {
        var user = await _userRepository.GetByUsername(guid)??throw new UserNotFoundException();
        if (type==UserType.USER)
        {
            user.MakeUser();
        }

        if (type==UserType.ADMIN)
        {
            user.MakeAdmin();
        }

        await _userRepository.UpdateAsync(user);
        return Ok();
    }
    [Authorize]
    public async Task<IActionResult> GetUserGrid(GridQueryModel model)
    {
        if (User.GetRole()!="SuperAdmin")
        {
            return Problem("You are not authorized");
        }
        var users = (await _userRepository.GetAllAsync()).SkipWhile(x=>x.UserType==UserType.SUPERUSER.ToString()).Select(x=>new{x.Name,x.UserName,Type=x.UserType.ToString()}).ToList();
        if (model.current > 1)
        {
            users = users.Skip((model.current - 1)*10).ToList();
        }
        users = users.Take(model.rowCount).ToList();
        model.total = users.Count;
        return Ok(model.Fill(users));
    }
}
