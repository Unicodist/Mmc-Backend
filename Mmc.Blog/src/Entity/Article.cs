using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class Article : IArticle
{
    public Article(string title, string body, DateTime someDate, ICategory category, IBlogUser blogUser)
    {
        Title = title;
        Body = body;
        Category = (Category)category;
        AuthorAdmin = (BlogUser)blogUser;
        PostedDate = someDate;
    }

    public long Id { get; }
    public string Title { get; }
    public string Body { get; }
    public DateTime PostedDate { get; }
    public long AdminId => AuthorAdmin.Id;
    public long? CategoryId => Category.Id;
    public BlogUser AuthorAdmin { get; set; }
    public Category Category { get; set; }
    IBlogUser IArticle.AuthorAdmin => AuthorAdmin;
    ICategory IArticle.Category => Category;
}