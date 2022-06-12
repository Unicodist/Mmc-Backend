using System.ComponentModel;

namespace Mmc.User.ViewModel;

public class UserLoginViewModel
{
    [PasswordPropertyText]
    public string Password { get; set; }
    public string Username { get; set; }
}