using Mmc.Data.Model.User;
using Mmc.Notice.BaseType;
using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Enum;

namespace Mmc.Data.Model.Notice
{
    public class NoticeModel : INotice
    {
        public NoticeModel(string title, string? body, DateTime postedOn, string? picture, long adminId, GuidType guid)
        {
            Title = title;
            Body = body;
            PostedOn = postedOn;
            Picture = picture;
            AdminId = adminId;
            Guid = guid;
        }

        public long Id { get; }
        public string Title { get; set; }
        public string? Body { get; set; }
        public DateTime PostedOn { get; set; }
        public string? Picture { get; set; }
        public Status Status { get; protected set; }
        public long AdminId { get; set; }
        public virtual UserModel Author { get; set; }
        public GuidType Guid { get; set; }
        public virtual ICollection<ICourse> Courses { get; }

        public void Deactivate()
        {
            Status = Status.Inactive;
        }

        public void AddCourse(ICourse course)
        {
            Courses.Add(course);
        }

        INoticeUser INotice.Author => Author;
    }
}
