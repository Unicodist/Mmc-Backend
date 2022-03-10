using Mmc.Core.Entity;

namespace Mmc.Core.Repository;

public interface BlogPostRepositoryInterface
{
    public Task<BlogMaster> GetBlogById(int id);
}