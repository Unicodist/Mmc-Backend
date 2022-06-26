using Mmc.Notice.Entity.Interface;

namespace Mmc.Notice.Repository;

public interface INoticeUserRepository
{
    Task<INoticeUser> GetNoticeUserById(long id);
    INoticeUser GetByUsername(string userName);

}
