using Mmc.User.Dto;
using Mmc.User.Entity.Interface;

namespace Mmc.User.Service;

public interface IUserService
{
    public Task<IUser> Create(UserCreateDto dto);
    public Task Update(UserUpdateDto dto);
    Task<IUser> ValidateUser(UserLoginDto userLoginDto);
}
