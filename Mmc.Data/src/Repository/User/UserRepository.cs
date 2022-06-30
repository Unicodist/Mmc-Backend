using Microsoft.EntityFrameworkCore;
using Mmc.Data.Model;
using Mmc.Data.Model.Core;
using Mmc.Data.Model.User;
using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Exception;
using Mmc.Notice.Repository;
using Mmc.User.Entity.Interface;
using Mmc.User.UserException;
using Mmc.User.Repository;

namespace Mmc.Data.Repository.User;

public class UserRepository : BaseRepository<UserModel>, IUserUserRepository, INoticeUserRepository
{
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    #region User

    public async Task<IUser> GetUserUserById(long id)
    {
        return await base.GetByIdAsync(id).ConfigureAwait(false)??throw new UserNotFoundException();
    }
    public async Task<IUser> InsertAsync(IUser user)
    {
        var uModel = new UserModel(user.Name, user.UserType, user.Email, user.Password, user.UserName, (OrganizationModel)user.Organization);
        uModel.AddProfilePicture(user.Picture);
        await base.InsertAsync(uModel);
        return uModel;
    }
    public async Task<IUser?> GetByUsername(string username)
    {
        return await GetQueryable().SingleOrDefaultAsync(x => x.UserName == username);
    }

    public Task UpdateAsync(IUser user)
    {
        return base.UpdateAsync((UserModel)user);
    }

    public async Task<ICollection<IUser>> GetAllAsync()
    {
        return (await base.GetAllAsync()).Cast<IUser>().ToList();
    }

    public async Task<ICollection<IUser>> GetByName(string name)
    {
        return await GetQueryable().Where(x=>x.Name==name).Cast<IUser>().ToListAsync();
    }

    #endregion

    #region Notice

    public async Task<INoticeUser> GetNoticeUserById(long id) => await base.GetByIdAsync(id).ConfigureAwait(false)?? throw new UserNotFoundException();

    INoticeUser INoticeUserRepository.GetByUsername(string userName) => GetQueryable().SingleOrDefault(x => x.UserName == userName)??throw new PublisherNotFoundException();

    #endregion
}
