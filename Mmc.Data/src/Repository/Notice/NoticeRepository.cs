using Mmc.Core.Repository;
using Mmc.Data.Model.Notice;
using Mmc.Notice.Entity.Interface;

namespace Mmc.Data.Repository.Notice;

public class NoticeRepository : BaseRepository<NoticeModel>, NoticeRepositoryInterface
{
    public NoticeRepository(BaseDbContext dbContext) : base(dbContext)
    {
        
    }

    public new async Task<ICollection<INotice>> GetAll()
    {
        return (await base.GetAll().ConfigureAwait(false)).Cast<INotice>().ToList();
    }

    public async Task<INotice> GetById(long id)
    {
        return await base.GetById(id).ConfigureAwait(false);
    }

    public Task Insert(INotice noticeCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task Update(INotice noticeUpdateDto)
    {
        throw new NotImplementedException();
    }
}