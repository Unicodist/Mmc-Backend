using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class Category : ICategory
{
    public long Id { get; }
    public string Name { get; }
    public string Description { get; }
    public Status Status { get; }
    public ICollection<IArticle> BlogPosts { get; }
}