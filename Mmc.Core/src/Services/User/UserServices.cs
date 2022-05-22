using System.Security.Claims;
using Mmc.Blog.ViewModel;
using Mmc.Core.Dto;
using Mmc.User.Dto;
using Mmc.User.Entity.Interface;
using Mmc.User.UserException;
using Mmc.User.Repository;

namespace Mmc.User.Service;

public class UserServices : IUserService
{
    private readonly IUserRepository _userRepo;

    public UserServices(IUserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    public async Task<IUser> Create(UserCreateDto userCreateDto)
    {
        var user = _userRepo.CreateInstance(userCreateDto.Name,userCreateDto.Email,userCreateDto.Password, userCreateDto.Username);
        return await _userRepo.InsertAsync(user);
    }

    public async Task<IUser> ValidateUser(UserLoginDto userCreateDto)
    {
        var user = await _userRepo.GetByUsername(userCreateDto.Username)??throw new UserNotFoundException();
        if (BCrypt.Net.BCrypt.Verify(userCreateDto.Password,user.Password))
        {
            return user;
        }

        throw new WrongPasswordException();
    }
}