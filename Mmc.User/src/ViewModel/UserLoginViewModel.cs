using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mmc.User.ViewModel;

public class UserLoginViewModel
{
    [DisplayName("Password:")]
    [MaxLength(50)]
    public string Password { get; set; }
    [DisplayName("Username:")]
    public string Username { get; set; }
    public string? ReturnUrl { get; set; }
}
