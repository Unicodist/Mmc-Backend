using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Blog.Service;

public class ToxicCommentService : IToxicCommentService
{
    private readonly ISuspiciousCommentRepository _suspiciousCommentRepository;

    public ToxicCommentService(ISuspiciousCommentRepository suspiciousCommentRepository)
    {
        _suspiciousCommentRepository = suspiciousCommentRepository;
    }

    public async Task Create(IComment c)
    {
        var sc = new ToxicComment(c);
        await _suspiciousCommentRepository.InsertAsync(sc);
    }

    public Task DeleteComment(IComment c)
    {
        throw new NotImplementedException();
    }
}
