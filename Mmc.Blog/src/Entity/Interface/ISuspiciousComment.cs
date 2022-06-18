using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface ISuspiciousComment
{
    long Id { get; }
    long CommentId { get; }
    Status status { get; }
    IComment Comment { get; }
}