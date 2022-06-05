namespace Mmc.Blog.Dto;

public class ArticleCreateDto
{
    public ArticleCreateDto(string title, string body,long adminId, long categoryId)
    {
        Title = title;
        Body = body;
        AdminId = adminId;
        CategoryId = categoryId;
    }

    public string Title { get; set; }
    public string Body { get; set; } 
    public long AdminId { get; set; }
    public long CategoryId { get; set; }
}