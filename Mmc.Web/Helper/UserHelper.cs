using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;

namespace Mechi.Backend.Helper;

public static class UserHelper
{
    public static IBlogUserRepository? UserRepository;
    public static IBlogUser GetCurrentBlogUser(this ControllerBase claims)
    {
        return UserRepository.GetByUsername(claims.User.Claims.FirstOrDefault(x=>x.Type==ClaimTypes.NameIdentifier).ToString());
    }
}