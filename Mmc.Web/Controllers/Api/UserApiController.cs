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
    public async Task<IActionResult> MakeUser(string guid)
    {
        return await ChangeUserType(guid, UserType.USER);
    }
    [HttpPost]
    public async Task<IActionResult> MakeStaff(string guid)
    {
        return await ChangeUserType(guid, UserType.ADMIN);
    }

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

    public async Task<IActionResult> GetUserGrid()
    {
        var users = (await _userRepository.GetAllAsync()).Select(x=>new{x.Name,x.UserName,Type=x.UserType.ToString()});
        return Ok(users);
    }
}
