using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Blog.Service;

public class InteractionLogService : IInteractionLogService
{
    private readonly IInteractionLogRepository _interactionLogRepository;
    private readonly IArticleRepository _articleRepository;
    private readonly ICommentRepository _commentRepository;

    public InteractionLogService(IInteractionLogRepository interactionLogRepository, IArticleRepository articleRepository, ICommentRepository commentRepository)
    {
        _interactionLogRepository = interactionLogRepository;
        _articleRepository = articleRepository;
        _commentRepository = commentRepository;
    }

    public Task Create(InteractionLogDto c)
    {
        var log = new InteractionLog(c.Article,c.User,c.Comment);
        _interactionLogRepository.InsertAsync(log);
        return Task.CompletedTask;
    }

    public async Task Create(IComment comment)
    {
        var log = new InteractionLog(comment, comment.User);
        await _interactionLogRepository.InsertAsync(log);
    }
}
