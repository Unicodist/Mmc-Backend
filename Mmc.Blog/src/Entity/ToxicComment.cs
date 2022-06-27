using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class ToxicComment : IToxicComment
{
    public ToxicComment(IComment comment)
    {
        Comment = comment;
        Status = ToxicCommentStatus.Active;
    }

    public long Id { get; set; }
    public long CommentId { get; set; }
    public ToxicCommentStatus Status { get; set; }
    public virtual IComment Comment { get; }
}
