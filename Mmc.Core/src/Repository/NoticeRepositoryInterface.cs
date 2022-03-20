using Mmc.Core.Dto;
using Mmc.Notice.Entity;
using Mmc.User.Entity;

namespace Mmc.Core.Repository;

public interface NoticeRepositoryInterface
{
    public Task<List<NoticeMasterEntity>> GetAll();
    public Task<NoticeMasterEntity> GetById(long id);
    public Task Insert(NoticeMasterEntity noticeCreateDto);
    public void Update(NoticeMasterEntity noticeUpdateDto);
}