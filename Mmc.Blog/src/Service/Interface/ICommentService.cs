using Mmc.Blog.Dto;
using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Service.Interface
{
    public interface ICommentService
    {
        Task<long> Create(CommentCreateDto c);
        Task Update(CommentUpdateDto comment);
    }
}
