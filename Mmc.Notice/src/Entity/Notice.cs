using Mmc.Notice.BaseType;
using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Enum;

namespace Mmc.Notice.Entity;

public class Notice : INotice
{
    public Notice(string title, string? body, string? picture, NoticeSeverity severity, INoticeUser author)
    {
        Title = title;
        Body = body;
        Author = author;
        Guid = new GuidType();
        Status = Status.Active;
        Severity = severity;
    }

    public long Id { get; set; }
    public string Title { get; set; }
    public string? Body { get; set; }
    public DateTime PostedOn { get; set; }
    public string? Picture { get; set; }
    public Status Status { get; set; }
    public NoticeSeverity Severity { get; set; }
    public long AdminId { get; set; }
    public INoticeUser Author { get; set; }
    public GuidType Guid { get; set; }
    public virtual ICollection<ICourse> Courses { get; set; }
    public void Deactivate()
    {
        Status = Status.Inactive;
    }

    public void AddCourse(ICourse course)
    {
        Courses.Add(course);
    }


}
