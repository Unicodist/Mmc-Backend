using Microsoft.EntityFrameworkCore;
using Mmc.Data.Model.Notice;
using Mmc.Data.Model.User;
using Mmc.Notice.Entity.Interface;
using Mmc.Notice.Exception;
using Mmc.Notice.Repository;

namespace Mmc.Data.Repository.Notice;

public class NoticeRepository : BaseRepository<NoticeModel>, INoticeRepository
{
    public NoticeRepository(AppDbContext dbContext) : base(dbContext)
    {
        
    }

    public new async Task<ICollection<INotice>?> GetAllAsync()
    {
        return (await base.GetAllAsync().ConfigureAwait(false)).Cast<INotice>().ToList();
    }

    public new async Task<INotice?> GetByIdAsync(long id)
    {
        return await base.GetByIdAsync(id).ConfigureAwait(false);
    }

    public async Task<INotice> Insert(INotice entity)
    {
        var noticeModel = new NoticeModel(entity.Title, entity.Body, entity.PostedOn, entity.Picture, (UserModel)entity.Author,
            entity.Guid,entity.Severity,entity.Status);
        await base.InsertAsync(noticeModel);
        return noticeModel;
    }

    public Task Update(INotice noticeUpdateDto)
    {
        return base.Update((NoticeModel)noticeUpdateDto);
    }

    public async Task<INotice> GetByGuidAsync(string guid)
    {
        return await GetQueryable().SingleOrDefaultAsync(x => x.Guid == guid) ?? throw new NoticeNotFoundException();
    }

    public IQueryable<INotice> GetQueryable()
    {
        return base.GetQueryable();
    }
}
