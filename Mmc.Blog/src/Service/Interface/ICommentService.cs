using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.src.Service.Interface
{
    public interface ICommentService
    {
        Task Create(IComment comment);
        Task Update(IComment comment);
    }
}
