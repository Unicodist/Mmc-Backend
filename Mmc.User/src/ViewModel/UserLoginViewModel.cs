using System.ComponentModel.DataAnnotations;

namespace Mmc.User.ViewModel;

public class UserLoginViewModel
{
    [DataType(DataType.Password)]
    public string Password { get; set; }
    public string Username { get; set; }
}