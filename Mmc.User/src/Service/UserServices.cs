using Mmc.User.Dto;
using Mmc.User.Entity.Interface;
using Mmc.User.Repository;
using Mmc.User.UserException;

namespace Mmc.User.Service;

public class UserServices : IUserService
{
    private readonly IUserUserRepository _userUserRepo;
    private readonly IPictureRepository _pictureRepo;
    private readonly ICampusRepository _campusRepository;

    public UserServices(IUserUserRepository userUserRepo, IPictureRepository pictureRepo, ICampusRepository campusRepository)
    {
        _userUserRepo = userUserRepo;
        _pictureRepo = pictureRepo;
        _campusRepository = campusRepository;
    }

    public async Task<IUser> Create(UserCreateDto dto)
    {
        var pictures = await _pictureRepo.GetAllAsync();
        var randomNumber = new Random(0).NextInt64(pictures.Count-1);
        var picture = (await _pictureRepo.GetAllAsync()).Skip((int)randomNumber).First();
        var user = new Entity.User(dto.Name,dto.Email,dto.Password, dto.Username, picture);
        return await _userUserRepo.InsertAsync(user);
    }
 
    public async Task Update(UserUpdateDto dto)
    {
        var user = await _userUserRepo.GetUserUserById(dto.Id);
        var picture = await _pictureRepo.GetByGuidAsync(dto.Picture);
        var college = await _campusRepository.GetByGuidAsync(dto.CampusGuid);
        user.Update(dto.Name, dto.Email, picture, dto.Password, dto.Username);
        await _userUserRepo.UpdateAsync(user);
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
