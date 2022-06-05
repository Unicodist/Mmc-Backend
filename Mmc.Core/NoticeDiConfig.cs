using Microsoft.Extensions.DependencyInjection;
using Mmc.Notice.Service;
using Mmc.Notice.Service.Interface;

namespace Mmc.Core;

public static class NoticeDiConfig
{
    public static void ConfNotice(this IServiceCollection services)
    {
        services.AddScoped<INoticeService, NoticeService>();
    }
}