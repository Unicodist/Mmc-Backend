using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;
using Mmc.Data.Model.User;

namespace Mmc.Data.Repository.Blog;

public class HeartRepository : BaseRepository<HeartModel>,IHeartRepository
{
    public HeartRepository(AppDbContext context) : base(context)
    {
    }
    public Task InsertAsync(IHeart heart)
    {
        var model = new HeartModel((UserModel)heart.User,(ArticleModel)heart.Article);
        return base.InsertAsync(model);
    }

    public new async Task<ICollection<IHeart>> GetAllAsync()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<IHeart>().ToList();
    }

    public async Task<ICollection<IHeart>?> GetAllByBlogIdAsync(long articleId)
    {
        return await GetQueryable().Where(x => x.ArticleId == articleId).ToListAsync();
    }

    public new IQueryable<IHeart> GetQueryable()
    {
        return base.GetQueryable();
    }

    public async Task<bool> GetByUserIdAndArticleId(long userId, long articleId)
    {
        return await GetQueryable().SingleOrDefaultAsync(x=>x.ArticleId==articleId&&x.UserId==userId)!=null;
    }

    public Task<int> GetHeartCountByArticleId(long articleId)
    {
        return GetQueryable().CountAsync(x => x.ArticleId == articleId);
    }

    public void Remove(IHeart heart)
    {
        base.Delete((HeartModel)heart);
    }

    public async Task<int> Count(string guid)
    {
        return await GetQueryable().CountAsync(x => x.Article.Guid == guid);
    }
}
