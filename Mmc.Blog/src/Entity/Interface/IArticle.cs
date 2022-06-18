using Mmc.Blog.BaseType;

namespace Mmc.Blog.Entity.Interface;

public interface IArticle
{
    long Id { get; }
    string Title { get; }
    string? Body { get; }
    DateOnly PostedDate { get; }
    TimeOnly PostedTime { get; }
    string Thumbnail { get; }
    GuidType Guid { get; }
    
    long UserId { get; }
    long? CategoryId { get; }
    
    IBlogUser User { get; }
    ICategory? Category { get; }
    void Update(string dtoTitle, string? dtoBody, ICategory category);
}