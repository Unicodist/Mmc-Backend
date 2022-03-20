using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mmc.Blog.Entity;
using Mmc.Core.Enum;
using Mmc.Notice.Entity;

namespace Mmc.User.Entity;
public class UserMasterEntity
{
    public long UserMasterId { get; set; }
    public string UserMasterName { get; set; } = null!;
    public UserType UserType { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public virtual IList<BlogMasterEntity?> Blogs { get; set; } = new List<BlogMasterEntity?>();
    public virtual IList<NoticeMasterEntity?> Notices { get; set; } = new List<NoticeMasterEntity?>();

    public void SetPassword(string password)
    {
        Password = password;
    }
}