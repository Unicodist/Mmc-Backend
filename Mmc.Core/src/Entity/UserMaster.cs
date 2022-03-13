using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mmc.Core.Entity;
[Table("user_master")]
public class UserMaster
{
    public long UserMasterId { get; set; }
    public string UserMasterName { get; set; } = null!;
    public int UserMasterCredentialId { get; set; }
    public UserCredentials UserMasterCredentials { get; set; } = null!;

    public virtual IList<BlogMaster>? Blogs { get; set; }
}