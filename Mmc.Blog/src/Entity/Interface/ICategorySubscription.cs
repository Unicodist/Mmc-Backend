using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface ICategorySubscription
{
    long Id { get; }
    long UserId { get; }
    long CategoryId { get; }
    IBlogUser User { get; }
    ICategory Category { get; }
    Status Status { get; }

    bool IsActive();
}