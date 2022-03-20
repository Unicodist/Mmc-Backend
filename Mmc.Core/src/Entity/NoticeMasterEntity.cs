using Mmc.User.Entity;

namespace Mmc.Notice.Entity
{
    public class NoticeMasterEntity
    {
        public long NoticeMasterId { get; set; }
        public string NoticeMasterTitle { get; set; } = null!;
        public string? NoticeMasterBody { get; set; }
        public DateTime PostedOn { get; set; }
        public string? NoticeMasterNoticePicture { get; set; }
        public long NoticeMasterAuthorId { get; set; }
        
        public virtual UserMasterEntity NoticeMasterEntityAuthor { get; set; }
    }
}
