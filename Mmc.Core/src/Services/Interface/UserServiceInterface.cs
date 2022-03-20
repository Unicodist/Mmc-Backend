using Mmc.Core.Dto;

namespace Mmc.Core.Services.Interface;

public interface UserServiceInterface
{
    public Task Create(UserCreateDto dto);
}