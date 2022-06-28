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
    ICollection<IPicture>? Pictures { get; }
    IOrganization Organization { get; }

    void MakeAdmin();
    void MakeUser();
}
