using Mmc.Notice.Entity.Interface;

namespace Mmc.Core.Repository;

public interface NoticeRepositoryInterface
{
     Task<ICollection<INotice>> GetAll();
     Task<INotice> GetById(long id);
     Task Insert(INotice noticeCreateDto);
     Task Update(INotice noticeUpdateDto);
}