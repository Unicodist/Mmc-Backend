using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;
using Mmc.Data.Model.User;

namespace Mmc.Data.Repository.Blog;

public class ArticleRepository : BaseRepository<ArticleModel>, IArticleRepository
{
    public ArticleRepository(BaseDbContext dbContext) : base(dbContext)
    {
        
    }

    public async Task<IArticle> GetArticleByIdAsync(long id)
    {
        return await GetByIdAsync(id).ConfigureAwait(false)??throw new ArticleNotFoundException();
    }

    public Task InsertAsync(IArticle article)
    {
        return base.InsertAsync((ArticleModel)article);
    }

    public async Task<ICollection<IArticle>> GetAllBlogAsync()
    {
        return (await GetAllAsync().ConfigureAwait(false)).Cast<IArticle>().ToList();
    }

    public IArticle CreateInstance(string title, string authorName, string body, DateTime postedDate, IBlogUser authorAdmin, ICategory category)
    {
        return new ArticleModel(title, authorName, body, postedDate, (BlogNoticeUserModel)authorAdmin, (CategoryModel)category);
    }

    public IQueryable<IArticle> GetBlogQueryable()
    {
        return GetQueryable();
    }
}