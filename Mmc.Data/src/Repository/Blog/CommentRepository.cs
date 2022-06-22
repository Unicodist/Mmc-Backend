using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Helper;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class CommentRepository : BaseRepository<CommentModel>,ICommentRepository
{
    public CommentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IComment?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id);
    }

    public Task Insert(IComment comment)
    {
        return base.InsertAsync(comment.Convert<CommentModel>());
    }

    public Task<ICollection<IComment>?> GetAll()
    {
        throw new NotImplementedException();
    }

    public IQueryable<IComment> GetQueryable()
    {
        throw new NotImplementedException();
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