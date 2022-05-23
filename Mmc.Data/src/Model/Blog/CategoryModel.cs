using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Data.Model.Blog;

public class CategoryModel : ICategory
{
    public CategoryModel(string name, string description)
    {
        Name = name;
        Description = description;
        Status = Status.Active;
    }
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Status Status { get; set; }
    public virtual ICollection<ArticleModel> BlogPosts { get; set; }
    ICollection<IArticle> ICategory.BlogPosts => BlogPosts.Cast<IArticle>().ToList();
}