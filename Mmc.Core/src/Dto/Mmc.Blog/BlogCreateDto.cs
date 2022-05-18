namespace Mmc.Core.Dto;

public class BlogCreateDto
{
    public string Title { get; set; } = null!;
    public long AdminId { get; set; }
    public string Body { get; set; } 
    public DateTime PostedDate { get; set; }
    public string AuthorName { get; set; } = null!;
}