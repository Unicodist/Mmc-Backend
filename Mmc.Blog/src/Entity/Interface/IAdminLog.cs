using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface IAdminLog
{
    public long Id { get; set; }
    public long AdminId { get; set; }
    public InteractionType Type { get; set; }
}