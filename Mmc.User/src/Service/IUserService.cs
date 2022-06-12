using Mmc.User.Dto;
using Mmc.User.Entity.Interface;

namespace Mmc.User.Service;

public interface IUserService
{
    public Task<IUser> Create(UserCreateDto dto);
    public Task<IUser> Update(UserUpdateDto dto);
    IUser ValidateUser(UserLoginDto userLoginDto);
}