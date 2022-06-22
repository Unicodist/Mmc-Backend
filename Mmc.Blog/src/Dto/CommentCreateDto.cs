namespace Mmc.Blog.Dto;

public class CommentCreateDto
{
    public CommentCreateDto(string articleGuid, string body, long userId)
    {
        ArticleGuid = articleGuid;
        Body = body;
        UserId = userId;
    }

    public string ArticleGuid { get; set; }
    public string Body { get; set; }
    public long UserId { get; set; }
}