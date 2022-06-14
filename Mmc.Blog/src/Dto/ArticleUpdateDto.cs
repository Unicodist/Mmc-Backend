namespace Mmc.Blog.Dto;

public class ArticleUpdateDto : ArticleCreateDto
{
    public ArticleUpdateDto(string title, string? body, long adminId, string? categoryGuid, string? thumbnail) : base(title, body, adminId, categoryGuid, thumbnail)
    {
    }

    public long Id { get; set; }
}