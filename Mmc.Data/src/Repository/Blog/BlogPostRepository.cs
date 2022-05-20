using Mmc.Blog.Entity;
using Mmc.Blog.Repository;
using Mmc.Core.Repository;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class BlogPostRepository : BaseRepository<BlogPostModel>, IBlogPostRepository
{
    public BlogPostRepository(BaseDbContext _dbContext) : base(_dbContext)
    {
        
    }

    public Task<IBlogPost> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Task Insert(IBlogPost blogPost)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<IBlogPost>> GetAll()
    {
        throw new NotImplementedException();
    }

    public IBlogPost CreateInstance(string title, string authorName, string body, DateTime postedDate)
    {
        throw new NotImplementedException();
    }
}