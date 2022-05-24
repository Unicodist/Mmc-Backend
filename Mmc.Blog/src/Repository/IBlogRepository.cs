using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IArticleRepository
{
    public Task<IArticle> GetArticleByIdAsync(long id);
    public Task InsertAsync(IArticle article);
    public Task<ICollection<IArticle>?> GetAllBlogAsync();
    IArticle CreateInstance(string title, string authorName, string body, DateTime postedDate, IBlogUser authorAdmin, ICategory category);
    IQueryable<IArticle> GetBlogQueryable();
}