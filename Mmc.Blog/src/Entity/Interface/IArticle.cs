using Mmc.Blog.BaseType;

namespace Mmc.Blog.Entity.Interface;

public interface IArticle
{
    long Id { get; }
    string Title { get; }
    string Body { get; }
    DateTime PostedDate { get; }
    string Thumbnail { get; }
    GuidType Guid { get; }
    
    long AdminId { get; }
    long? CategoryId { get; }
    
    IBlogUser AuthorAdmin { get; }
    ICategory? Category { get; }
}