using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Exception;
using Mmc.Blog.Repository;
using Mmc.Blog.Service.Interface;

namespace Mmc.Blog.Service;

public class HeartService : IHeartService
{
    private readonly IHeartRepository _heartRepository;
    private readonly IArticleRepository _articleRepository;
    private readonly IBlogUserRepository _blogUserRepository;

    public HeartService(IHeartRepository heartRepository, IArticleRepository articleRepository, IBlogUserRepository blogUserRepository)
    {
        _heartRepository = heartRepository;
        _articleRepository = articleRepository;
        _blogUserRepository = blogUserRepository;
    }

    public async Task Heart(HeartDto dto)
    {
        var article = await _articleRepository.GetByGuidAsync(dto.ArticleGuid)??throw new ArticleNotFoundException();
        var user = await _blogUserRepository.GetByIdAsync(dto.UserId) ?? throw new UserNotFoundException();
        var heart = new Heart(user,article);
        await _heartRepository.InsertAsync(heart).ConfigureAwait(false);
    }

    public Task UnHeart(HeartDto heartDto)
    {
        throw new NotImplementedException();
    }
}
