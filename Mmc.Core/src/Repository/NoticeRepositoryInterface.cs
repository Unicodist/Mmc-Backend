using Mmc.Core.Dto;
using Mmc.Notice.Entity;
using Mmc.User.Entity;

namespace Mmc.Core.Repository;

public interface NoticeRepositoryInterface
{
     Task<List<NoticeMasterEntity>> GetAll();
     Task<NoticeMasterEntity> GetById(long id);
     Task Insert(NoticeMasterEntity noticeCreateDto);
     Task Update(NoticeMasterEntity noticeUpdateDto);
}