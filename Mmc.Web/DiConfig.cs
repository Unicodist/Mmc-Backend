using Mmc.Blog.Service.Interface;
using Mmc.Core.Services;
using Mmc.Core.Services.Interface;
using Mmc.Notice.Service;
using Mmc.User.Service;

namespace Mechi.Backend;

public static class DiConfig
{
    public static void ConfWeb(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserServices>();
        services.AddScoped<IBlogService, BlogService>();
        services.AddScoped<NoticeServiceInterface, NoticeServices>();
    }
}