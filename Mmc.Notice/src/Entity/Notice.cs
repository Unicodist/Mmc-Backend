using Mmc.Notice.BaseType;
using Mmc.Notice.Entity.Interface;

namespace Mmc.Notice.Entity;

public class Notice : INotice
{
    public Notice(string title, string? body, string? picture, NoticeUser author)
    {
        Title = title;
        Author = author;
        Guid = new GuidType();
    }

    public long Id { get; set; }
    public string Title { get; set; }
    public string? Body { get; set; }
    public DateTime PostedOn { get; set; }
    public string? Picture { get; set; }
    public long AdminId { get; set; }
    public NoticeUser Author { get; set; }
    INoticeUser INotice.Author => Author;
    public GuidType Guid { get; set; }
}