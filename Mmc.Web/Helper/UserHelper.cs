using Microsoft.AspNetCore.Mvc;
using Mmc.Data;
using Mmc.Data.Model.User;
using Mmc.Data.Repository.User;

namespace Mechi.Backend.Helper;

public static class UserHelper
{
    private static readonly UserRepository UserRepository = new (new AppDbContext());
    public static async Task<UserModel> GetCurrentUser(this ControllerBase controller)
    {
        return (UserModel)await UserRepository.GetByUsername(controller.User.Claims.SingleOrDefault(x => x.Type == "Name").Value);
    }
}