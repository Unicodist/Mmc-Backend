namespace Mmc.Blog.Entity.Interface;

public interface IArticle
{
    long Id { get; }
    string Title { get; }
    long AdminId { get; }
    string Body { get; }
    DateTime PostedDate { get; }
    string AuthorName { get; }
    IBlogUser AuthorAdmin { get; }
    ICategory Category { get; }
}