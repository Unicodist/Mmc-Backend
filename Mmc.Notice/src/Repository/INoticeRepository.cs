using Mmc.Notice.Entity.Interface;

namespace Mmc.Notice.Repository;

public interface INoticeRepository
{
     Task<ICollection<INotice>?> GetAllAsync();
     Task<INotice?> GetByIdAsync(long id);
     Task<INotice> Insert(INotice entity);
     Task Update(INotice noticeUpdateDto);
     Task<INotice> GetByGuidAsync(string guid);
     IQueryable<INotice> GetQueryable();
}
