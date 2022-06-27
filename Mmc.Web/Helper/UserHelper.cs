using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Repository;

namespace Mechi.Backend.Helper;

public static class UserHelper
{
    public static IBlogUserRepository? BlogUserRepository;
    public static INoticeUserRepository? NoticeUserRepository;
    public static IBlogUser GetCurrentBlogUser(this ControllerBase claims)
    {
        var userName = claims.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
        return BlogUserRepository.GetByUsername(userName);
    }
    public static INoticeUser GetCurrentNoticeUser(this ControllerBase claims)
    {
        var userName = claims.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
        return NoticeUserRepository.GetByUsername(userName);
    }

    public static string? GetRole(this ClaimsPrincipal principal)
    {
        return principal.Claims.SingleOrDefault(x => x.Type == ClaimTypes.Role)?.Value.ToString();
    }
}
