using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class ArticleModel : IArticle
{
    public ArticleModel(long id)
    {
        Id = id;
    }

    public ArticleModel(string title, string authorName, string body, DateTime postedDate, Mmc.User.Entity.Interface.IUser authorAdmin, CategoryModel category)
    {
        Title = title;
        AuthorName = authorName;
        Body = body;
        PostedDate = postedDate;
        AuthorAdmin = (UserModel)authorAdmin;
        Category = category;

    }

    public long Id { get; }
    public string Title { get; } = null!;
    public long AdminId
    {
        get;
        set;
    }

    public string Body { get; } = null!;
    public DateTime PostedDate { get; }
    public string AuthorName { get; } = null!;
    public long CategoryId { get; set; }
    public virtual UserModel AuthorAdmin { get; } = null!;
    IBlogUser IArticle.AuthorAdmin => AuthorAdmin;
    public virtual CategoryModel Category { get; set; } = null!;
    ICategory IArticle.Category => Category;
}