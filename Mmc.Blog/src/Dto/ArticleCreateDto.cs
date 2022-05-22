namespace Mmc.Blog.Dto;

public class ArticleCreateDto
{
    public string Title { get; set; } = null!;
    public long AdminId { get; set; }
    public string Body { get; set; } 
    public DateTime PostedDate { get; set; }
    public string AuthorName { get; set; } = null!;
    public long CategoryId { get; set; }
}