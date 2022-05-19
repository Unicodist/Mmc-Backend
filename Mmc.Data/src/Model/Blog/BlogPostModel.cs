using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class BlogPostModel : IBlogPost
{
    public long Id { get; private set; }
    public string Title { get; set; } = null!;
    public long AdminId { get; set; }
    public string Body { get; set; } = null!;
    public DateTime PostedDate { get; set; }
    public string AuthorName { get; set; } = null!;
    public virtual UserModel AuthorAdmin { get; set; } = null!;
    IUser IBlogPost.AuthorAdmin => AuthorAdmin;
}