using System.Security.Claims;
using Mechi.Backend.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Diagnostics;
using Mmc.Core;
using Mmc.Data;
using Serilog;

namespace Mechi.Backend;

public static class Startup
{
    public static void Configure(this IServiceCollection services)
    {
        services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(option =>
        {
            option.LoginPath = "/Login/";
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

    public static void ConfigureExceptionHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(error =>
        {
            error.Run(async context =>
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature != null)
                {
                    Log.Error($"Something went wrong. {contextFeature.Error}");
                    await context.Response.WriteAsync(new ErrorModel
                    {
                        StatusCode = context.Response.StatusCode, Message =$"{contextFeature.Error.Message}"
                    }.ToString());
                }
            });
        });
    }
}
