using Mmc.Core.Services.Interface;
using Mmc.Core.Dto;
using Mmc.Core.Repository;
using Mmc.User.Entity;

namespace Mmc.Core.Services;

public class UserServices : UserServiceInterface
{
    private UserRepositoryInterface _userRepositoryInterface;
    public async Task Create(UserCreateDto userCreateDto)
    {
        UserMasterEntity user = new UserMasterEntity()
        {
            UserMasterName = userCreateDto.Name,
            Email = userCreateDto.Email,
            Password = userCreateDto.Password,
            UserType = userCreateDto.UserType
        };
        await _userRepositoryInterface.Insert(user);
    }
}