using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class SuspiciousComment : ISuspiciousComment
{
    public long Id { get; set; }
    public long CommentId { get; set; }
    public Status status { get; set; }
    public virtual IComment Comment { get; }
}