namespace Mechi.Backend.ApiModel.Notice;

public class NoticeResponseApiModel
{
    public string Title { get; init; } = null!;
    public string? Body { get; init; }
    public string Date { get; init; } = null!;
    public string? Picture { get; init; }
    public string Guid { get; set; }
}