namespace Mmc.Blog.ApiModel.Notice;

public class NoticeResponseApiModel
{
    public string Title { get; init; } = null!;
    public string? Body { get; init; }
    public string Date { get; init; } = null!;
    public string? Picture { get; init; }
}