using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Data.Model.Blog;

public class ToxicCommentModel : IToxicComment
{
    public ToxicCommentModel(CommentModel comment, ToxicCommentStatus status)
    {
        Comment = comment;
        Status = status;
    }

    public ToxicCommentModel()
    {
    }

    public long Id { get; protected set; }
    public long CommentId { get; set; }
    public ToxicCommentStatus Status { get; private set; }
    public virtual CommentModel Comment { get; set; }
    IComment IToxicComment.Comment => Comment;
}
