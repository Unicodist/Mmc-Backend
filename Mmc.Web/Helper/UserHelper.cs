using Microsoft.AspNetCore.Mvc;
using Mmc.Data;
using Mmc.Data.Model.User;
using Mmc.Data.Repository.User;

namespace Mechi.Backend.Helper;

public static class UserHelper
{
    private static readonly UserRepository UserRepository = new (new AppDbContext(new ConfigurationManager()));
    public static UserModel GetCurrentUser(this ControllerBase controller)
    {
        return (UserModel) UserRepository.GetByUsername(controller.User.Claims.SingleOrDefault(x => x.Type == "Name").Value);
    }
}