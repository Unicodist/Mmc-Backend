namespace Mmc.Blog.Dto;

public class HeartDto
{
    public HeartDto(long userId, string articleGuid)
    {
        UserId = userId;
        ArticleGuid = articleGuid;
    }

    public string ArticleGuid { get; set; }
    public long UserId { get; set; }
}
