using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class ArticleModel : IArticle
{
    public ArticleModel()
    {
    }

    public ArticleModel(string title, string? body, DateOnly postedDate, IBlogUser authorAdmin, ICategory? category, string thumbnail, GuidType guid)
    {
        Title = title;
        Body = body;
        PostedDate = postedDate;
        Thumbnail = thumbnail;
        Guid = guid;
        AuthorAdmin = (UserModel)authorAdmin;
        Category = (CategoryModel)category;

    }

    public long Id { get; protected set; }
    public string Title { get; set; } = null!;
    public TimeOnly PostedTime { get; set; }
    public string Thumbnail { get; }
    public GuidType Guid { get; }

    public long UserId
    {
        get;
        set;
    }

    public string? Body { get; protected set; } = null!;
    public DateOnly PostedDate { get; }
    public long? CategoryId { get;  }

    public virtual UserModel AuthorAdmin { get; } = null!;
    IBlogUser IArticle.User => AuthorAdmin;
    public virtual CategoryModel? Category { get; protected set; }
    public void Update(string dtoTitle, string? dtoBody, ICategory category)
    {
        Title = dtoTitle;
        Body = dtoBody;
        Category = (CategoryModel)category;
    }

    ICategory? IArticle.Category => Category;
}
