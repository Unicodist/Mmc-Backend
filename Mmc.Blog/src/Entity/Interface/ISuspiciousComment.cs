using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface ISuspiciousComment
{
    public long Id { get; set; }
    public long CommentId { get; set; }
    public Status status { get; set; }
}