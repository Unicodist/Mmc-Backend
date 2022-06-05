using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class Article : IArticle
{
    public long Id { get; }
    public string Title { get; }
    public string Body { get; }
    public DateTime PostedDate { get; }
    public string AuthorName { get; }
    public long AdminId { get; }
    public long CategoryId { get; }
    private BlogUser AuthorAdmin { get; set; }
    private Category Category { get; set; }
    IBlogUser IArticle.AuthorAdmin => AuthorAdmin;
    ICategory IArticle.Category => Category;
}