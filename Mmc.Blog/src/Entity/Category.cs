using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class Category : ICategory
{
    public Category(string name, string description)
    {
        Name = name;
        Description = description;
        Guid = new GuidType();
        Status = Status.Active;
        BlogPosts = new List<IArticle>();
    }

    public long Id { get; }
    public string Name { get; }
    public string Description { get; }
    public Status Status { get; }
    public ICollection<IArticle> BlogPosts { get; }
    public GuidType Guid { get; set; }
}