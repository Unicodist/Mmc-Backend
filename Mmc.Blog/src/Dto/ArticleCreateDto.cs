namespace Mmc.Blog.Dto;

public class ArticleCreateDto
{
    public ArticleCreateDto(string title, string? body,long userId, string? categoryGuid, string? thumbnail)
    {
        Title = title;
        Body = body;
        UserId = userId;
        CategoryGuid = categoryGuid;
        Thumbnail = thumbnail;
    }

    public string Title { get; set; }
    public string? Body { get; set; } 
    public long UserId { get; set; }
    public string? CategoryGuid { get; set; }
    public string? Thumbnail { get; set; }
}