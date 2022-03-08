using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mmc.Api.Entities;
[Table("user_master")]
public class UserMaster
{
    [Key]
    public int Id { get; set; }
    [Column("name")] public string Name { get; set; }
    [Column("credentials")] private int CredId { get; set; }
    
    public UserCredentials UserCredentials { get; set; }
}