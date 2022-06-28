using Mmc.User.Entity.Interface;
using Mmc.User.Enum;

namespace Mmc.User.Entity;

public class User : IUser
{
    public User(string name, string email, string password, string userName,
        IOrganization organization)
    {
        Name = name;
        Email = email;
        Password = password;
        UserName = userName;
        UserType = UserType.USER;
        Organization = organization;
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public UserType UserType { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public long? PictureId { get; }
    public IPicture Picture { get; }

    public IOrganization Organization { get; set; }

    public void MakeAdmin()
    {
        UserType = UserType.ADMIN;
    }

    public void MakeUser()
    {
        UserType = UserType.USER;
    }

    public void Update(string dtoName, string dtoEmail, IPicture picture, string dtoPassword, string dtoUsername,
        IOrganization organization)
    {
        throw new NotImplementedException();
    }
}
