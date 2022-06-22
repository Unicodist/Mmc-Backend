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
        var userName = claims.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
        return UserRepository.GetByUsername(userName);
    }

    public static string? GetRole(this ClaimsPrincipal principal)
    {
        return principal.Claims.SingleOrDefault(x => x.Type == ClaimTypes.Role)?.Value.ToString();
    }
}