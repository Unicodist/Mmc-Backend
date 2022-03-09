using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mmc.Data;

namespace Mmc.Entities;

public class UserCredentials :BaseDbContext
{
    [Key] public int Id { get; set; }
    [Column("email")] public string Email { get; set; }
    [Column("password")] private string Password { get; set; }
    

    public bool MatchPassword(string password)
    {
        return Password.Equals(password);
    }
}