using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;
using Mmc.Data.Model.User;

namespace Mmc.Data.Repository.Blog;

public class CommentRepository : BaseRepository<CommentModel>,ICommentRepository
{
    public CommentRepository(AppDbContext context) : base(context)
    {
    }

    public new async Task<IComment?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id);
    }

    public async Task<IComment> InsertAsync(IComment comment)
    {
        var cModel = new CommentModel(comment.Body, (UserModel)comment.User, (ArticleModel)comment.Article,comment.Status,comment.Guid);
        await base.InsertAsync(cModel);
        return cModel;
    }

    public async Task<ICollection<IComment>?> GetAllAsync()
    {
        return (await base.GetAllAsync()).Cast<IComment>().ToList();
    }

    public new IQueryable<IComment> GetQueryable()
    {
        return base.GetQueryable();
    }

    public async Task<ICollection<IComment>> GetByArticleIdAsync(long id)
    {
        return await base.GetQueryable().Where(x => x.ArticleId == id).Cast<IComment>().ToListAsync();
    }

    public async Task<IComment?> GetByGuidAsync(string guid)
    {
        return await base.GetQueryable().SingleOrDefaultAsync(x => x.Guid == guid).ConfigureAwait(false);
    }

    public Task UpdateAsync(IComment comment)
    {
        return base.Update((CommentModel)comment);
    }
}
