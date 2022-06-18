namespace Mmc.Blog.Dto;

public class ArticleUpdateDto : ArticleCreateDto
{
    public ArticleUpdateDto(string title, string? body, long userId, string? categoryGuid, string? thumbnail) : base(title, body, userId, categoryGuid, thumbnail)
    {
    }

    public long Id { get; set; }
}