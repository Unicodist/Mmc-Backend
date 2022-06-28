using Microsoft.EntityFrameworkCore;
using Mmc.Data.Model;
using Mmc.Data.Model.User;
using Mmc.User.Entity.Interface;
using Mmc.User.Repository;

namespace Mmc.Data.Repository.User;

public class PictureRepository : BaseRepository<PictureModel>, IPictureRepository
{
    public PictureRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IPicture> InsertAsync(IPicture picture)
    {
        var model = new PictureModel(picture.Guid,picture.Type.ToString(),picture.Location, picture.UploadedDate,(UserModel)picture.UploadedBy);
        await base.InsertAsync(model);
        return model;
    }

    public async Task<IPicture> GetByUsername(string name)
    {
        return await GetQueryable().FirstAsync(x => x.UploadedBy.Name == name);
    }

    public async Task<ICollection<IPicture>> GetAllAsync()
    {
        return (await base.GetAllAsync()).Cast<IPicture>().ToList();
    }

    public async Task<IPicture> GetByGuidAsync(string guid)
    {
        return await GetQueryable().FirstAsync(x => x.Guid == guid);
    }
}
