using Mmc.Core.Entity;

namespace Mmc.Core.Repository;

public interface NoticeRepositoryInterface
{
    public Task<NoticeMaster?> GetNoticeById(long id);
    public Task<IList<NoticeMaster>> GetAll();
}