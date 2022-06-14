using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class Article : IArticle
{
    public Article(string title, string? body, DateTime someDate, ICategory? category, IBlogUser blogUser, string? thumbnail)
    {
        Title = title;
        Body = body;
        Category = category;
        AuthorAdmin = blogUser;
        Thumbnail = thumbnail;
        Guid = new GuidType();
        PostedDate = someDate;
    }

    public long Id { get; }
    public string Title { get; set; }
    public string? Body { get; set; }
    public DateTime PostedDate { get; }
    public string? Thumbnail { get; }
    public GuidType Guid { get; }
    public long AdminId => AuthorAdmin.Id;
    public long? CategoryId => Category?.Id;
    public IBlogUser AuthorAdmin { get; }
    public ICategory? Category { get; set; }

    public void Update(string dtoTitle, string? dtoBody, ICategory category)
    {
        Title = dtoTitle;
        Body = dtoBody;
        Category = category;
    }
}