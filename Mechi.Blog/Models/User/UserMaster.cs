using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mechi.Backend.Models.User;

public class UserMaster
{
    [Key] public int Id { get; set; }
    [Column("firstname")] public string? FirstName { get; set; }
    [Column("lastname")] public string? LastName { get; set; }
    [Column("credentials")] public int Credentials { get; set; }
}