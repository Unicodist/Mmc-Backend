using Mmc.Core.Entity;
using Mmc.Data;
using Mmc.Data.Repository;

namespace Mechi.Backend.Services;

public class NoticeServices
{
    public Task<NoticeMaster?> GetNoticeById(long id)
    {
        return new NoticeRepository(new BaseDbContext()).GetNoticeById(id);
    }
    public async Task<List<NoticeMaster>> GetAll()
    {
        return new NoticeRepository(new BaseDbContext()).GetQueryable().ToList<NoticeMaster>();
    }
}