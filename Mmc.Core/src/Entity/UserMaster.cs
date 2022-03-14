using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mmc.Core.Entity;
[Table("user_master")]
public class UserMaster
{
    public long UserMasterId { get; set; }
    public string UserMasterName { get; set; } = null!;
    public int UserMasterCredentialId { get; set; }
    public UserCredentials UserMasterCredential { get; set; } = null!;

    public virtual IList<BlogMaster?> Blogs { get; set; } = new List<BlogMaster?>();
    public virtual IList<NoticeMaster?> Notices { get; set; } = new List<NoticeMaster?>();
}