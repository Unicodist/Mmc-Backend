using Microsoft.Extensions.DependencyInjection;
using Mmc.Blog.Repository;
using Mmc.Core.Repository;
using Mmc.Data.Repository;
using Mmc.Data.Repository.Blog;
using Mmc.Data.Repository.Notice;
using Mmc.Data.Repository.User;
using Mmc.User.Repository;

namespace Mmc.Data;

public static class DiConfig
{
    public static void ConfData(this IServiceCollection services)
    {
        #region Blog

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IBlogPostRepository, BlogPostRepository>();

        #endregion

        #region Notice
        
        services.AddScoped<NoticeRepositoryInterface, NoticeRepository>();

        #endregion
 
        #region User
        
        services.AddScoped<IUserRepository, UserRepository>();

        #endregion
    }
}