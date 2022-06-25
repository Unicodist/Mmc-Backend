using Mmc.Blog.Dto;
using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Service.Interface;

public interface IInteractionLogService
{
    Task Create(InteractionLogDto c);
    Task Create(IComment comment);
}
