using Mmc.Core.Services;
using Mmc.Core.Services.Interface;

namespace Mechi.Backend;

public static class DiConfig
{
    public static void ConfWeb(this IServiceCollection services)
    {
        services.AddScoped<UserServiceInterface, UserServices>();
        services.AddScoped<UserServices, UserServices>();
        services.AddScoped<BlogServiceInterface, BlogServices>();
        services.AddScoped<BlogServices, BlogServices>();
        services.AddScoped<NoticeServiceInterface, NoticeServices>();
        services.AddScoped<NoticeServices, NoticeServices>();
    }
}