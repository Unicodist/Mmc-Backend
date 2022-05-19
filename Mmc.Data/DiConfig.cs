using Microsoft.Extensions.DependencyInjection;
using Mmc.Core.Repository;
using Mmc.Data.Repository;
using Mmc.Data.Repository.Blog;
using Mmc.Data.Repository.Notice;
using Mmc.Data.Repository.User;

namespace Mmc.Data;

public static class DiConfig
{
    public static void ConfData(this IServiceCollection services)
    {
        services.AddScoped<UserRepositoryInterface, UserRepository>();
        services.AddScoped<UserRepository, UserRepository>();
        services.AddScoped<IBlogPostRepository, BlogPostRepository>();
        services.AddScoped<BlogPostRepository, BlogPostRepository>();
        services.AddScoped<NoticeRepositoryInterface, NoticeRepository>();
        services.AddScoped<NoticeRepository, NoticeRepository>();
    }
}