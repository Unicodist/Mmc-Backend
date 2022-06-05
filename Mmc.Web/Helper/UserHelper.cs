using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.User;
using Mmc.User.Repository;

namespace Mechi.Backend.Helper;

public static class UserHelper
{
    public static IUserUserRepository? UserRepository;
    public static UserModel GetCurrentBlogUser(this ControllerBase claims)
    {
        var userName = claims.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
        return (UserModel)UserRepository.GetByUsername(userName);
    }
}