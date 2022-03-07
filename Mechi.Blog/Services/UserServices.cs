using Mechi.Backend.Dto;
using Mechi.Backend.Models.Data;
using Mechi.Backend.Models.User;

namespace Mechi.Backend.Services;

public class UserServices
{
    private BlogDbContext _context;
    public async Task<UserMaster> Create(UserCreateDto userCreateDto)
    {
        UserCredentials createUserCredentials = new UserCredentials()
        {
            Email = userCreateDto.Email,
            Password = userCreateDto.Password
        };
        _context.UserCredentials.Add(createUserCredentials);
        UserMaster createUserMaster = new()
        {
            Credentials = createUserCredentials.Id,
            FirstName = userCreateDto.FirstName,
            LastName = userCreateDto.LastName
        };
        _context.UserMasters.Add(createUserMaster);
        _context.SaveChangesAsync();

        return _context.UserMasters.Find(createUserMaster.Id);
    }

    public async Task<UserMaster> Update(int user_id, UserUpdateDto userUpdateDto)
    {
        UserMaster userMaster = _context.UserMasters.Find(user_id);
        UserCredentials userCredentials = _context.UserCredentials.Find(userMaster.Credentials);

        _context.UserCredentials.Update(userCredentials);
        _context.UserMasters.Update(userMaster);
        _context.SaveChanges();

        return userMaster;
    }
}