using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public interface IBlogPost
{
    long Id { get; }
    string Title { get; }
    long AdminId { get; }
    string Body { get; }
    DateTime PostedDate { get; }
    string AuthorName { get; }
    IUser AuthorAdmin { get; }
}