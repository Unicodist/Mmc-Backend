using Mmc.Data.Model.User;
using Mmc.Notice.Entity.Interface;

namespace Mmc.Data.Model.Notice
{
    public class NoticeModel : INotice
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public DateTime PostedOn { get; set; }
        public string? Picture { get; set; }
        public long AdminId { get; set; }
        public virtual UserModel Author { get; set; }
        IUser INotice.Author => Author;
    }
}
