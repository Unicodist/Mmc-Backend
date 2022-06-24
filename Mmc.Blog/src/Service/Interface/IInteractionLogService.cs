using Mmc.Blog.Dto;
using Mmc.Blog.Entity;

namespace Mmc.Blog.Service.Interface;

public interface IInteractionLogService
{
    Task Create(InteractionLogDto c);
    Task Create(Comment comment);
}
