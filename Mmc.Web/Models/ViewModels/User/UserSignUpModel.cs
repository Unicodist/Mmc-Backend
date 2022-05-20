using System.ComponentModel.DataAnnotations;

namespace Mmc.Blog.ViewModel;

public class UserSignUpModel
{
    public UserSignUpModel(string firstName, string lastName, string email, string password, string confirm, bool rememberMe)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        Confirm = confirm;
        RememberMe = rememberMe;
    }

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