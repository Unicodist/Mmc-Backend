using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mmc.Core.Entity;

public class BlogMaster
{
    public int BlogMasterId { get; set; }
    public string BlogMasterTitle { get; set; } = null!;
    public int BlogMasterAuthorAdminId { get; set; }
    public string BlogMasterBody { get; set; } = null!;
    public DateTime BlogMasterPostedDate { get; set; }
    public string BlogMasterAuthorName { get; set; } = null!;
    public virtual UserMaster BlogMasterAuthorAdmin { get; set; } = null!;
}