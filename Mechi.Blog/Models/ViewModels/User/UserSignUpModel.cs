using System.ComponentModel.DataAnnotations;

namespace Mmc.Blog.ViewModel;

public class UserSignUpModel
{
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
    
    [Required]
    public string Confirm { get; set; }
    
    [Required]
    public bool RememberMe { get; set; }
}