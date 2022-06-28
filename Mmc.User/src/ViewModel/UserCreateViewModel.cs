using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mmc.User.ViewModel;

public class UserCreateViewModel
{
    [Required(ErrorMessage = "This field is required")]
    [DataType(DataType.Text)]
    [MinLength(4)]
    [MaxLength(10)]
    [DisplayName("First Name")]
    public string FirstName { get; set; } 
    
    [Required(ErrorMessage = "This field is required")]
    [DataType(DataType.Text)]
    [MinLength(4)]
    [MaxLength(10)]
    [DisplayName("Last Name")]
    public string  LastName { get; set; }
    
    [Required(ErrorMessage = "You cannot leave this empty")]
    [DisplayName("Select Campus")]
    public string CollegeGuid { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [DataType(DataType.EmailAddress)]
    [MinLength(4)]
    [MaxLength(50)]
    [DisplayName("Email")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [DataType(DataType.Password)]
    [MinLength(8)]
    [MaxLength(32)]
    [DisplayName("Password")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [DataType(DataType.Password)]
    [DisplayName("Confirm Password")]
    public string Confirm { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [MinLength(8)]
    [MaxLength(32)]
    [DisplayName("Username")]
    public string Username { get; set; }
}
