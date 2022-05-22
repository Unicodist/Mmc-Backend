using Microsoft.Extensions.DependencyInjection;
using Mmc.Core.Services.User;
using Mmc.User.Service;

namespace Mmc.Core;

public static class UserDiConfig
{
    public static void ConfUser(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserServices>();
    }
}