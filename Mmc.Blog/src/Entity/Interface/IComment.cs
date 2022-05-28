using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface IComment
{
    long Id { get; }
    string Body { get; }
    long UserId { get; }
    long ArticleId { get; }
    long ParentId { get; }
    Status Status { get; set; }
    IBlogUser User { get; }
    IArticle Article { get; }
    IComment Parent { get; }
    ICollection<IComment>? Replies { get; }
    void Update(string body);
}