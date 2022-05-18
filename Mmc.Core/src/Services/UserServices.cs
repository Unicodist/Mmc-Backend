using Mmc.Core.Services.Interface;
using Mmc.Core.Dto;
using Mmc.Core.Repository;
using Mmc.User.Entity;

namespace Mmc.Core.Services;

public class UserServices : UserServiceInterface
{
    private UserRepositoryInterface _userRepo;
    public async Task Create(UserCreateDto userCreateDto)
    {
        var user = _userRepo.CreateInstance(userCreateDto.Name,userCreateDto.Email,userCreateDto.Password, userCreateDto.Username);
        await _userRepo.Insert(user);
    }
}