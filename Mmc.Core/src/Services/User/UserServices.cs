using Mmc.Core.Dto;
using Mmc.User.Dto;
using Mmc.User.Entity.Interface;
using Mmc.User.Repository;
using Mmc.User.Service;
using Mmc.User.UserException;

namespace Mmc.Core.Services.User;

public class UserServices : IUserService
{
    private readonly IUserUserRepository _userUserRepo;

    public UserServices(IUserUserRepository userUserRepo)
    {
        _userUserRepo = userUserRepo;
    }

    public async Task<IUser> Create(UserCreateDto userCreateDto)
    {
        var user = _userUserRepo.CreateInstance(userCreateDto.Name,userCreateDto.Email,userCreateDto.Password, userCreateDto.Username);
        return await _userUserRepo.InsertAsync(user);
    }

    public async Task<IUser> ValidateUser(UserLoginDto userCreateDto)
    {
        var user = await _userUserRepo.GetByUsername(userCreateDto.Username)??throw new UserNotFoundException();
        if (BCrypt.Net.BCrypt.Verify(userCreateDto.Password,user.Password))
        {
            return user;
        }

        throw new WrongPasswordException();
    }
}