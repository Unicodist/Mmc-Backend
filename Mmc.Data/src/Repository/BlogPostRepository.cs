using Mmc.Blog.Entity;
using Mmc.Core.Repository;

namespace Mmc.Data.Repository;

public class BlogPostRepository : BaseRepository<BlogMasterEntity>, BlogPostRepositoryInterface
{
    public BlogPostRepository(BaseDbContext _dbContext) : base(_dbContext)
    {
        
    }

    public Task<BlogMasterEntity> GetById(long id)
    {
        throw new NotImplementedException();
    }
}