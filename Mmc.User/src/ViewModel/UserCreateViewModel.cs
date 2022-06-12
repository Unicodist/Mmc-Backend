using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mmc.User.ViewModel;

public class UserCreateViewModel
{
    [Required(ErrorMessage = "This field is required")]
    [MinLength(4)]
    [MaxLength(10)]
    [DisplayName("First Name")]
    public string FirstName { get; set; } 
    
    [Required(ErrorMessage = "This field is required")]
    [MinLength(4)]
    [MaxLength(10)]
    [DisplayName("Last Name")]
    public string  LastName { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [MinLength(4)]
    [MaxLength(10)]
    [DisplayName("Email")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [MinLength(8)]
    [MaxLength(32)]
    [PasswordPropertyText]
    [DisplayName("Password")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [PasswordPropertyText]
    [DisplayName("Confirm Password")]
    public string Confirm { get; set; }

    public bool Remember { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [MinLength(8)]
    [MaxLength(32)]
    [DisplayName("Username")]
    public string Username { get; set; }
}