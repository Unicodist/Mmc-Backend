using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface IArticleRepository
{
    public Task<IArticle?> GetByIdAsync(long id);
    public Task InsertAsync(IArticle a);
    public Task<ICollection<IArticle>?> GetAllBlogAsync();
    Task<IArticle> GetByGuidAsync(string guid);
    IQueryable<IArticle> GetQueryable();
    Task UpdateAsync(IArticle blog);
}
