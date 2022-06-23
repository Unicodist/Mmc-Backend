using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity;
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

    public async Task InsertAsync(IComment comment)
    {
        var cModel = new CommentModel(comment.Body, (UserModel)comment.User, (ArticleModel)comment.Article,comment.Status,comment.Guid);
        await base.InsertAsync(cModel);
        typeof(Comment).GetProperty(nameof(Comment.Id))!.SetValue(comment,cModel.Id);
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
}
