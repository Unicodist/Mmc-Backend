using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Repository.Blog;

public class SuspiciousCommentRepository : BaseRepository<ToxicCommentModel> , ISuspiciousCommentRepository
{
    public SuspiciousCommentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IToxicComment> InsertAsync(IToxicComment comment)
    {
        var susModel = new ToxicCommentModel((CommentModel)comment.Comment,comment.Status);
        await base.InsertAsync(susModel);
        return susModel;
    }

    public Task<ICollection<IToxicComment>?> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<IToxicComment>?> GetAllByBlogIdAsync(long articleId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<IToxicComment>?> GetAllByUserIdAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<IToxicComment>> GetByUserIdAndArticleId(long userId, long articleId)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetCountByArticleId(long articleId)
    {
        throw new NotImplementedException();
    }
}
