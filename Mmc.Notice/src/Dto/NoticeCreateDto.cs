namespace Mmc.Notice.Dto;

public class NoticeCreateDto
{
    public long Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Body { get; set; }
    public DateTime PostedOn { get; set; }
    public string? Picture { get; set; }
}