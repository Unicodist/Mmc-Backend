using Mmc.Core.Enum;

namespace Mmc.Core.Dto;

public class UserCreateDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserType UserType { get; set; }
}