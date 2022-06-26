using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Enum;

namespace Mmc.Notice.Dto;

public class NoticeUpdateDto : NoticeCreateDto
{
    public long Id { get; set; }

    public NoticeUpdateDto(long id,string title, string? body, string? picture, NoticeSeverity severity, INoticeUser author) : base(title, body, picture, severity, author)
    {
        Id = id;
    }
}
