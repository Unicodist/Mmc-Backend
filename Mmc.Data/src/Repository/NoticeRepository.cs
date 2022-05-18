using Mmc.Core.Dto;
using Mmc.Core.Repository;
using Mmc.Data.Model;
using Mmc.Data.Model.Notice;
using Mmc.Notice.Entity;
using Mmc.Notice.Entity.Interface;

namespace Mmc.Data.Repository;

public class NoticeRepository : BaseRepository<NoticeModel>, NoticeRepositoryInterface
{
    public NoticeRepository(BaseDbContext dbContext) : base(dbContext)
    {
        
    }

    public Task<List<INotice>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<INotice> GetById(long id)
    {
        throw new NotImplementedException();
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