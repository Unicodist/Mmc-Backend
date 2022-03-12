using Mechi.Backend.Dto;
using Mmc.Core.Entity;
using Mmc.Data;
using Mmc.Data.Repository;

namespace Mmc.Blog.Services;

public class UserServices
{
    private BaseDbContext _context = new BaseDbContext();
    public async Task<UserMaster?> Create(UserCreateDto userCreateDto)
    {
        UserCredentials createUserCredentials = new UserCredentials()
        {
            UserCredentialsEmail = userCreateDto.Email,
        };
        createUserCredentials.SetPassword(userCreateDto.Password);
        _context.UserCredentials.Add(createUserCredentials);
        UserMaster createUserMaster = new()
        {
            UserMasterCredentialId = createUserCredentials.UserCredentialsId,
            UserMasterName = userCreateDto.FirstName+' '+userCreateDto.LastName
        };
        _context.UserMasters.Add(createUserMaster);
        await _context.SaveChangesAsync();

        return _context.UserMasters.Find(createUserMaster.UserMasterCredentialId);
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