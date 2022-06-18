using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Data.Model.Blog;

public class SuspiciousCommentModel : ISuspiciousComment
{
    public long Id { get; protected set; }
    public long CommentId { get; set; }
    public Status status { get; private set; }
    public IComment Comment { get; set; }
}