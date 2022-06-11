using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Data.Helper;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class ArticleRepository : BaseRepository<ArticleModel>, IArticleRepository
{
    public ArticleRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }

    public new async Task<IArticle?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id).ConfigureAwait(false)??throw new ArticleNotFoundException();
    }

    public Task InsertAsync(IArticle a)
    {
        var model = new ArticleModel(a.Title,a.Body,a.PostedDate,a.AuthorAdmin,a.Category,a.Thumbnail,a.Guid);
        return base.InsertAsync(model);
    }

    public async Task<ICollection<IArticle>?> GetAllBlogAsync()
    {
        return (await GetAllAsync().ConfigureAwait(false)).Cast<IArticle>().ToList();
    }

    public IQueryable<IArticle> GetBlogQueryable()
    {
        return GetQueryable();
    }
}