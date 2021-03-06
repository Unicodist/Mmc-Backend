using Mmc.Blog.BaseType;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity.Interface;

public interface ICategory
{
    public long Id { get; }
    public string Name { get; }
    public string Description { get; }
    public Status Status { get; }

    public ICollection<IArticle> BlogPosts { get; }
    GuidType Guid { get; set; }
    void Update(string dtoName, string dtoDescription);
}