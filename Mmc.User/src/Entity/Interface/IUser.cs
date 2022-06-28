using Mmc.User.Enum;

namespace Mmc.User.Entity.Interface;
public interface IUser
{
    long Id { get; }
    string Name { get; }
    UserType UserType { get; }
    string Email { get; }
    string Password { get; }
    string UserName { get; }
    long? PictureId { get; }
    IPicture Picture { get; }
    IOrganization Organization { get; }

    void MakeAdmin();
    void MakeUser();
    void Update(string dtoName, string dtoEmail, IPicture picture, string dtoPassword, string dtoUsername,
        IOrganization organization);
}
