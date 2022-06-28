using Mmc.User.Dto;
using Mmc.User.Entity;
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

    public async Task<IUser> Create(UserCreateDto dto)
    {
        var user = new Entity.User(dto.Name,dto.Email,dto.Password, dto.Username, new Picture(dto.Picture));
        return await _userUserRepo.InsertAsync(user);
    }
 
    public Task<IUser> Update(UserUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public async Task<IUser> ValidateUser(UserLoginDto userLoginDto)
    {
        var user = await _userUserRepo.GetByUsername(userLoginDto.Username)??throw new UserNotFoundException();
        if (BCrypt.Net.BCrypt.Verify(userLoginDto.Password,user.Password))
        {
            return user;
        }
        throw new WrongPasswordException();
    }
}
