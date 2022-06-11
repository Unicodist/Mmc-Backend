namespace Mmc.Blog.Dto;

public class ArticleCreateDto
{
    public ArticleCreateDto(string title, string body,long adminId, string categoryGuid)
    {
        Title = title;
        Body = body;
        AdminId = adminId;
        CategoryGuid = categoryGuid;
    }

    public string Title { get; set; }
    public string Body { get; set; } 
    public long AdminId { get; set; }
    public string CategoryGuid { get; set; }
}