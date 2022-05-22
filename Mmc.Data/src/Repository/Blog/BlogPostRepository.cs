using Mmc.Blog.Entity;
using Mmc.Blog.Repository;
using Mmc.Core.Repository;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class BlogPostRepository : BaseRepository<ArticleModel>, IBlogPostRepository
{
    public BlogPostRepository(BaseDbContext _dbContext) : base(_dbContext)
    {
        
    }

    public Task<IArticle> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task Insert(IArticle article)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<IArticle>> GetAll()
    {
        throw new NotImplementedException();
    }

    public IArticle CreateInstance(string title, string authorName, string body, DateTime postedDate)
    {
        throw new NotImplementedException();
    }
}