using Mmc.User.Entity;

namespace Mmc.Notice.Entity
{
    public class NoticeMaster
    {
        public long NoticeMasterId { get; set; }
        public string NoticeMasterTitle { get; set; } = null!;
        public string? NoticeMasterBody { get; set; }
        public DateTime PostedOn { get; set; }
        public string? NoticeMasterNoticePicture { get; set; }
        
        public virtual UserMaster NoticeMasterAuthor { get; set; }
    }
}
