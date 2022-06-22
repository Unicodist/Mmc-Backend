using Microsoft.Extensions.DependencyInjection;
using Mmc.Blog.Service;
using Mmc.Blog.Service.Interface;
using Mmc.Blog.src.Service;
using Mmc.Core.Services.Blog;

namespace Mmc.Core;

public static class BlogDiConfig
{
    public static void ConfBlog(this IServiceCollection services)
    {
        services.AddScoped<IBlogService,BlogService>();
        services.AddScoped<ICategoryService,CategoryService>();
        services.AddScoped<ICommentService,CommentService>();
    }
}