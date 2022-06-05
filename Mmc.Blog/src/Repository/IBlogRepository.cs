using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IArticleRepository
{
    public Task<IArticle?> GetByIdAsync(long id);
    public Task InsertAsync(IArticle article);
    public Task<ICollection<IArticle>?> GetAllBlogAsync();
    IQueryable<IArticle> GetBlogQueryable();
}