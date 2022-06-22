using Mmc.Blog.BaseType;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface IComment
{
    long Id { get; }
    string Body { get; }
    long UserId { get; }
    long ArticleId { get; }
    Status Status { get; set; }
    IBlogUser User { get; }
    IArticle Article { get; }
    GuidType Guid { get; }
    void Update(string body);
    void FlagAsSuspicious();
}