using Mmc.Notice.Entity.Interface;

namespace Mmc.Notice.Repository;

public interface NoticeRepositoryInterface
{
     Task<ICollection<INotice>?> GetAllAsync();
     Task<INotice?> GetByIdAsync(long id);
     Task Insert(INotice noticeCreateDto);
     Task Update(INotice noticeUpdateDto);
}