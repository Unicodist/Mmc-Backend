using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Mmc.Core;
using Mmc.Data;

namespace Mechi.Backend;

public static class Startup
{
    public static void Configure(this IServiceCollection services)
    {
        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(option =>
        {
            option.LoginPath = "/Account/Login/";
            option.AccessDeniedPath = "/Account/Unauthorized/";
        });
        
        services.AddAuthorization(opt =>
        {
            opt.AddPolicy("ApproveUser", policy =>
            {
                policy.RequireClaim(ClaimTypes.Role,"Superuser","Admin","Mod");
            });
            opt.AddPolicy("ApprovePost", policy =>
            {
                policy.RequireClaim(ClaimTypes.Role,"Superuser","Admin","Mod");
            });
        });

// Add services to the container.
        services.AddControllersWithViews();
        services.AddSession();

        services.ConfBlog();
        services.ConfData();
        services.ConfNotice();
        services.ConfUser();
        services.ConfWeb();
    }
}