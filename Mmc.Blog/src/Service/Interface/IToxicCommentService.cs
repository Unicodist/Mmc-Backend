using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Service.Interface;

public interface IToxicCommentService
{
    Task Create(IComment c);
    Task DeleteComment(IComment c);
}
