using Mmc.Blog.Entity;
using Mmc.Core.Enum;
using Mmc.User.Entity;

namespace Mmc.Core.Repository;

public interface BlogPostRepositoryInterface
{
    public Task<BlogMasterEntity> GetById(long id);
    public Task Insert(BlogMasterEntity blogMasterEntity);
}