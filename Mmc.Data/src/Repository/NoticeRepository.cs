using Mmc.Core.Dto;
using Mmc.Core.Repository;
using Mmc.Notice.Entity;

namespace Mmc.Data.Repository;

public class NoticeRepository : BaseRepository<NoticeMasterEntity>, NoticeRepositoryInterface
{
    public NoticeRepository(BaseDbContext dbContext) : base(dbContext)
    {
        
    }
}