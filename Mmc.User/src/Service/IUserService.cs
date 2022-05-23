using Mmc.Core.Dto;
using Mmc.User.Dto;
using Mmc.User.Entity.Interface;

namespace Mmc.User.Service;

public interface IUserService
{
    public Task<IUser> Create(UserCreateDto dto);
    IUser ValidateUser(UserLoginDto userCreateDto);
}