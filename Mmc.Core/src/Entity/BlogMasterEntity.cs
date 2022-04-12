using Mmc.User.Entity;

namespace Mmc.Blog.Entity;

public class BlogMasterEntity
{
    public long BlogMasterId { get; private set; }
    public string BlogMasterTitle { get; set; } = null!;
    public long BlogMasterAuthorAdminId { get; set; }
    public string BlogMasterBody { get; set; } = null!;
    public DateTime BlogMasterPostedDate { get; set; }
    public string BlogMasterAuthorName { get; set; } = null!;
    public virtual UserMasterEntity BlogMasterEntityAuthorAdmin { get; set; } = null!;
}