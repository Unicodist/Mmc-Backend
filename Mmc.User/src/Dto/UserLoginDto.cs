namespace Mmc.User.Dto;

public class UserLoginDto
{
    public UserLoginDto(string password, string username)
    {
        Password = password;
        Username = username;
    }

    public UserLoginDto()
    {
        
    }

    public string Password { get; init; } = null!;
    public string Username { get; init; } = null!;
}