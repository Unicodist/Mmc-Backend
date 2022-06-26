using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;
using Mmc.Data.Model.User;

namespace Mmc.Data.Repository.Blog;

public class UpvoteRepository : BaseRepository<HeartModel>,IUpvoteRepository
{
    
    public UpvoteRepository(AppDbContext context) : base(context)
    {
    }
    public Task InsertAsync(IHeart heart)
    {
        var model = new HeartModel((UserModel)heart.User,(ArticleModel)heart.Article);
        return base.InsertAsync(model);
    }

    public new async Task<ICollection<IHeart>?> GetAllAsync()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<IHeart>().ToList();
    }

    public new IQueryable<IHeart> GetQueryable()
    {
        return base.GetQueryable();
    }

    public async Task<IHeart?> GetByUserIdAndArticleId(long userId, long articleId)
    {
        return await GetQueryable().SingleOrDefaultAsync(x => x.ArticleId == articleId && x.UserId == userId);
    }
}
