using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;
using Mmc.Data.Model.User;

namespace Mmc.Data.Repository.Blog;

public class UpvoteRepository : BaseRepository<UpvoteModel>,IUpvoteRepository
{
    
    public UpvoteRepository(AppDbContext context) : base(context)
    {
    }
    public Task InsertAsync(IUpvote upvote)
    {
        var model = new UpvoteModel((UserModel)upvote.User,(ArticleModel)upvote.Article);
        return base.InsertAsync(model);
    }

    public new async Task<ICollection<IUpvote>?> GetAllAsync()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<IUpvote>().ToList();
    }

    public new IQueryable<IUpvote> GetQueryable()
    {
        return base.GetQueryable();
    }

    public async Task<IUpvote?> GetByUserIdAndArticleId(long userId, long articleId)
    {
        return await GetQueryable().SingleOrDefaultAsync(x => x.ArticleId == articleId && x.UserId == userId);
    }
}
