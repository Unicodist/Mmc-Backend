namespace Mmc.Blog.Dto;

public class LikeDto
{
    public LikeDto(long userId, long articleId)
    {
        UserId = userId;
        ArticleId = articleId;
    }

    public long ArticleId { get; set; }
    public long UserId { get; set; }
}
