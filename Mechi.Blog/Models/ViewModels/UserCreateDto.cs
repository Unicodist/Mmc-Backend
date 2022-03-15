using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mechi.Blog.ViewModel;

public class UserCreateDto
{
    public UserCreateDto(string? firstName, string? lastName, string? email, string? password, string? confirm)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        Confirm = confirm;
    }

    [Required]
    [DisplayName("First Name")]
    public string? FirstName { get; set; } 
    
    [Required]
    [MinLength(4)]
    [MaxLength(10)]
    [DisplayName("Last Name")]
    public string?  LastName { get; set; }
    
    [Required]
    [MinLength(4)]
    [MaxLength(10)]
    [DisplayName("Email")]
    public string? Email { get; set; }
    
    [Required]
    [MinLength(8)]
    [MaxLength(32)]
    [PasswordPropertyText]
    [DisplayName("Password")]
    public string? Password { get; set; }
    
    [Required]
    [PasswordPropertyText]
    [DisplayName("Confirm Password")]
    public string? Confirm { get; set; }
}