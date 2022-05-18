using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Notice
{
    public class NoticeModel
    {
        public long NoticeMasterId { get; set; }
        public string NoticeMasterTitle { get; set; } = null!;
        public string? NoticeMasterBody { get; set; }
        public DateTime PostedOn { get; set; }
        public string? NoticeMasterNoticePicture { get; set; }
        public long NoticeMasterAuthorId { get; set; }
        public virtual UserModel NoticeMasterEntityAuthor { get; set; }
    }
}
