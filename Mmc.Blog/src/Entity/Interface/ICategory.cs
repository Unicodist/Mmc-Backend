using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface ICategory
{
    public long Id { get; }
    public string Name { get; }
    public string Description { get; }
    public Status Status { get; }

    public ICollection<IBlogPost> BlogPosts { get; }
}