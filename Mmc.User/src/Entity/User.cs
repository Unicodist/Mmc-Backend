using Mmc.User.Entity.Interface;
using Mmc.User.Enum;

namespace Mmc.User.Entity;

public class User : IUser
{
    public long Id { get; set; }
    public string Name { get; set; }
    public UserType UserType { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public IPicture? Picture { get; set; }
    public void MakeAdmin()
    {
        UserType = UserType.ADMIN;
    }

    public void MakeUser()
    {
        UserType = UserType.USER;
    }
}
