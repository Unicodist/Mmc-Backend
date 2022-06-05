using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Helper;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class UpvoteRepository : BaseRepository<UpvoteModel>,IUpvoteRepository
{
    
    public UpvoteRepository(AppDbContext context) : base(context)
    {
    }
    
    public async Task<IUpvote?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id).ConfigureAwait(false);
    }

    public Task InsertAsync(IUpvote category)
    {
        return base.InsertAsync(category.Convert<UpvoteModel>());
    }

    public async Task<ICollection<IUpvote>?> GetAllAsync()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<IUpvote>().ToList();
    }

    public IQueryable<IUpvote> GetQueryable()
    {
        return base.GetQueryable();
    }
}