using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class CategorySubscription : ICategorySubscription
{
    public long Id { get; set; }
    public long UserId { get; set; }
    public long CategoryId { get; set; }
    public Status Status { get; set; }
    public bool IsActive() => Status == Status.Active;
    public IBlogUser User { get; set; }
    public ICategory Category { get; set; }
}