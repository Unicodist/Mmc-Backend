using Mmc.Core.Entity;
using Mmc.Core.Repository;

namespace Mmc.Data.Repository;

public class NoticeRepository : BaseRepository<NoticeMaster>, NoticeRepositoryInterface
{
    public NoticeRepository(BaseDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IList<NoticeMaster>> GetAll()
    {
        return await Task.FromResult(GetQueryable().ToList());
    }

    public async Task<NoticeMaster?> GetNoticeById(long id)
    {
        return await GetItem(id).ConfigureAwait(false);
    }
}