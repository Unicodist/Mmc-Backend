using Mmc.User.Entity.Interface;
using Mmc.User.Enum;

namespace Mmc.User.Entity;

public class User : IUser
{
    public User(string name, string email, string password, string userName, Picture picture)
    {
        Name = name;
        Email = email;
        Password = password;
        UserName = userName;
        UserType = UserType.USER;
        Pictures.Add(picture);
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public UserType UserType { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public ICollection<IPicture>? Pictures { get; set; } = new List<IPicture>();

    public IOrganization Organization { get; set; }

    public void MakeAdmin()
    {
        UserType = UserType.ADMIN;
    }

    public void MakeUser()
    {
        UserType = UserType.USER;
    }
}
