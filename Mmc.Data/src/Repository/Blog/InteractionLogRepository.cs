using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;
using Mmc.Data.Model.User;

namespace Mmc.Data.Repository.Blog;

public class InteractionLogRepository : BaseRepository<InteractionLogModel>, IInteractionLogRepository
{
    public InteractionLogRepository(AppDbContext context) : base(context)
     {
     }
    public new async Task<IInteractionLog?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id);
    }

    public Task InsertAsync(IInteractionLog interaction)
    {
        var model = new InteractionLogModel((ArticleModel?)interaction.Article,(CommentModel?)interaction.Comment,(UserModel)interaction.User,interaction.InteractionType,interaction.OldValue,interaction.NewValue,interaction.DateTime);
        return base.InsertAsync(model);
    }

    public async Task<ICollection<IInteractionLog>?> GetAll()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<IInteractionLog>().ToList();
    }

    public new IQueryable<IInteractionLog> GetQueryable()
    {
        return base.GetQueryable();
    }

    
}
