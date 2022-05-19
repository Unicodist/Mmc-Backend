using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Data.Model.Blog;

public class CategoryModel : ICategory
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public ICollection<BlogPostModel> BlogPosts { get; set; }
    ICollection<IBlogPost> ICategory.BlogPosts => BlogPosts.Cast<IBlogPost>().ToList();
}