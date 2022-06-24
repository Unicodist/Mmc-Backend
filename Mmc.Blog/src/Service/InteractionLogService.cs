using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Blog.Service;

public class InteractionLogService : IInteractionLogService
{
    private readonly IInteractionLogRepository _interactionLogRepository;
    private readonly IArticleRepository _articleRepository;

    public InteractionLogService(IInteractionLogRepository interactionLogRepository, IArticleRepository articleRepository)
    {
        _interactionLogRepository = interactionLogRepository;
        _articleRepository = articleRepository;
    }

    public Task Create(InteractionLogDto c)
    {
        var log = new InteractionLog(c.Article,c.User,c.Comment);
        _interactionLogRepository.InsertAsync(log);
        return Task.CompletedTask;
    }

    public Task Create(Comment comment)
    {
        var log = new InteractionLog(comment, comment.User);
        _interactionLogRepository.InsertAsync(log);
        return Task.CompletedTask;
    }
}
