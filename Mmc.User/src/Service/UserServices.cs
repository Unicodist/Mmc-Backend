using Mmc.User.Dto;
using Mmc.User.Entity.Interface;
using Mmc.User.Repository;
using Mmc.User.UserException;

namespace Mmc.User.Service;

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
 
    public Task<IUser> Update(UserUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public IUser ValidateUser(UserLoginDto userLoginDto)
    {
        var user = _userUserRepo.GetByUsername(userLoginDto.Username)??throw new UserNotFoundException();
        if (BCrypt.Net.BCrypt.Verify(userLoginDto.Password,user.Password))
        {
            return user;
        }

        throw new WrongPasswordException();
    }
}