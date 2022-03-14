using Mmc.Blog.Entity;
using Mmc.Data.Repository;
using Mmc.Data;

namespace Mechi.Backend.Services;

public class BlogServices
{
    public async Task<BlogMaster?> GetById(long id)
    {
        return await new BlogPostRepository(new BaseDbContext()).GetItem(id);
    }
}