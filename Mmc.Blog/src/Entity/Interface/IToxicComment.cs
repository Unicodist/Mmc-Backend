using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface IToxicComment
{
    long Id { get; }
    long CommentId { get; }
    ToxicCommentStatus Status { get; }
    IComment Comment { get; }
}
