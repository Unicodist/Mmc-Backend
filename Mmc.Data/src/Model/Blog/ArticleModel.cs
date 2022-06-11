using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class ArticleModel : IArticle
{
    public ArticleModel()
    {
    }

    public ArticleModel(string title, string body, DateTime postedDate, IBlogUser authorAdmin, ICategory category, string thumbnail, GuidType guid)
    {
        Title = title;
        Body = body;
        PostedDate = postedDate;
        Thumbnail = thumbnail;
        Guid = guid;
        AuthorAdmin = (UserModel)authorAdmin;
        Category = (CategoryModel)category;

    }

    public long Id { get; }
    public string Title { get; } = null!;
    public string Thumbnail { get; }
    public GuidType Guid { get; }

    public long AdminId
    {
        get;
        set;
    }

    public string Body { get; } = null!;
    public DateTime PostedDate { get; }
    public long? CategoryId { get; set; }

    public virtual UserModel AuthorAdmin { get; } = null!;
    IBlogUser IArticle.AuthorAdmin => AuthorAdmin;
    public virtual CategoryModel Category { get; } = null!;
    ICategory IArticle.Category => Category;
}