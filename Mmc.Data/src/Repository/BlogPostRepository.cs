using Mmc.Blog.Entity;
using Mmc.Core.Repository;

namespace Mmc.Data.Repository;

public class BlogPostRepository : BaseRepository<BlogMaster>, BlogPostRepositoryInterface
{
    public BlogPostRepository(BaseDbContext _dbContext) : base(_dbContext)
    {
        
    }
}