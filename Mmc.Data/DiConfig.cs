using Microsoft.Extensions.DependencyInjection;
using Mmc.Blog.Repository;
using Mmc.Core.Repository;
using Mmc.Data.Repository.Blog;
using Mmc.Data.Repository.Core;
using Mmc.Data.Repository.Notice;
using Mmc.Data.Repository.User;
using Mmc.Notice.Repository;
using Mmc.User.Repository;

namespace Mmc.Data;

public static class DiConfig
{
    public static void ConfData(this IServiceCollection services)
    {
        #region core

        _ = services.AddScoped<ICourseRepository, CourseRepository>();
        _ = services.AddScoped<IFacultyRepository, FacultyRepository>();

        #endregion
        
        #region Blog

        _ = services.AddScoped<ICategoryRepository, CategoryRepository>();
        _ = services.AddScoped<IArticleRepository, ArticleRepository>();
        _ = services.AddScoped<IBlogUserRepository, UserRepository>();
        _ = services.AddScoped<ICommentRepository, CommentRepository>();
        _ = services.AddScoped<IUpvoteRepository, UpvoteRepository>();
        _ = services.AddScoped<IInteractionLogRepository, InteractionLogRepository>();

        #endregion

        #region Notice
        
        services.AddScoped<INoticeRepository, NoticeRepository>();
        services.AddScoped<INoticeUserRepository, UserRepository>();

        #endregion
 
        #region User
        
        services.AddScoped<IUserUserRepository, UserRepository>();
        services.AddScoped<UserRepository, UserRepository>();

        #endregion
    }
}
