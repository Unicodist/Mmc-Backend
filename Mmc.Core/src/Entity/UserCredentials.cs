using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mmc.Core.Entity;

public class UserCredentials
{
    [Key] public int Id { get; set; }
    [Column("email")] public string Email { get; set; }
    [Column("password")] private string Password { get; set; }
    

    public bool MatchPassword(string password)
    {
        return Password.Equals(password);
    }
}