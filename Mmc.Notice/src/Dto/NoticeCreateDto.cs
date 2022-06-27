using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Enum;

namespace Mmc.Notice.Dto;

public class NoticeCreateDto
{
    public NoticeCreateDto(string title, string? body, string? picture,NoticeSeverity severity, INoticeUser author)
    {
        Title = title;
        Body = body;
        Picture = picture;
        Severity = severity;
        Author = author;
    }

    public long Id { get; set; }
    public string Title { get; set; }
    public string? Body { get; set; }
    public DateTime PostedOn { get; set; }
    public string? Picture { get; set; }
    public NoticeSeverity Severity { get; set; }
    public INoticeUser Author { get; set; }
}
