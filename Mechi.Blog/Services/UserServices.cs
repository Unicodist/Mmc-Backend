using Mechi.Blog.ViewModel;
using Mmc.User.Entity;
using Mmc.Data;
using Mmc.Data.Repository;

namespace Mmc.Blog.Services;

public class UserServices
{
    private BaseDbContext _context = new BaseDbContext();
    public async Task<long?> Create(UserCreateDto userCreateDto)
    {
        UserMaster createUserMaster = new UserMaster()
        {
            UserMasterName = userCreateDto.FirstName + " " + userCreateDto.LastName,
            UserMasterCredential = new UserCredentials() { UserCredentialsEmail = userCreateDto.Email }
        };
        createUserMaster.UserMasterCredential.SetPassword(userCreateDto.Password);

        await _context.AddAsync(createUserMaster);
        return createUserMaster.UserMasterId;
    }
    public Task<long> Update(int userId, UserUpdateDto userUpdateDto)
    {
        UserMaster? userMaster = _context.UserMasters.Find(userId);
        UserCredentials? userCredentials = _context.UserCredentials.Find(userMaster?.UserMasterCredentialId);

        _context.UserCredentials.Update(userCredentials);
        _context.UserMasters.Update(userMaster);
        _context.SaveChanges();

        return Task.FromResult(userMaster.UserMasterId);
    }

    public async Task<UserMaster?> GetUserById(long id)
    {
        return await new UserRepository(_context).GetItem(id).ConfigureAwait(false);
    }
}