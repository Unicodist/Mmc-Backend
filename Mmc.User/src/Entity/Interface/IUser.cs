using Mmc.User.Enum;

namespace Mmc.User.Entity.Interface;
public interface IUser
{
    long Id { get; }
    string Name { get; }
    UserType UserType { get; }
    string Email { get; }
    string Password { get; }
    string UserName { get; set; }
}