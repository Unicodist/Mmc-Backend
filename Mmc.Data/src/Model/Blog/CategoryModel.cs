using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Data.Model.Blog;

public class CategoryModel : ICategory
{
    public CategoryModel()
    {
        
    }

    public CategoryModel(string categoryName, string categoryDescription, GuidType categoryGuid, Status categoryStatus)
    {
        Name = categoryName;
        Description = categoryDescription;
        Guid = categoryGuid;
        Status = categoryStatus;
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public virtual ICollection<ArticleModel> BlogPosts { get; set; }
    public GuidType Guid { get; set; }
    public void Update(string dtoName, string dtoDescription)
    {
        Name = dtoName;
        Description = dtoDescription;
    }

    ICollection<IArticle> ICategory.BlogPosts => BlogPosts.Cast<IArticle>().ToList();
}
