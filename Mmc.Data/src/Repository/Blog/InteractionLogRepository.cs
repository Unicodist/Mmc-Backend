using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Helper;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class InteractionLogRepository : BaseRepository<InteractionLogModel>, IInteractionLogRepository
{
    public InteractionLogRepository(AppDbContext context) : base(context)
     {
     }
    public async Task<IInteractionLog?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id);
    }

    public Task Insert(IInteractionLog category)
    {
        return base.InsertAsync(category.Convert<InteractionLogModel>());
    }

    public async Task<ICollection<IInteractionLog>?> GetAll()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<IInteractionLog>().ToList();
    }

    public IQueryable<IInteractionLog> GetQueryable()
    {
        return base.GetQueryable();
    }

    
}