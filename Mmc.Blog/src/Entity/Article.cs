using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class Article : IArticle
{
    public Article(string title, string body, DateTime someDate, ICategory? category, IBlogUser blogUser, string thumbnail, GuidType guid)
    {
        Title = title;
        Body = body;
        Category = category;
        AuthorAdmin = blogUser;
        Thumbnail = thumbnail;
        Guid = guid;
        PostedDate = someDate;
    }

    public long Id { get; }
    public string Title { get; }
    public string Body { get; }
    public DateTime PostedDate { get; }
    public string Thumbnail { get; }
    public GuidType Guid { get; }
    public long AdminId => AuthorAdmin.Id;
    public long? CategoryId => Category?.Id;
    public IBlogUser AuthorAdmin { get; }
    public ICategory? Category { get; }
}