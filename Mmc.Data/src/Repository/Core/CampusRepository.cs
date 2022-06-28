using Microsoft.EntityFrameworkCore;
using Mmc.Data.Model.Address;
using Mmc.Data.Model.Core;
using Mmc.User.Entity.Interface;
using Mmc.User.Repository;

namespace Mmc.Data.Repository.Core;

public class CampusRepository : BaseRepository<OrganizationModel> , ICampusRepository
{
    public CampusRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IOrganization> InsertAsync(IOrganization campus)
    {
        var model = new OrganizationModel(campus.Name, campus.Guid, (VdcModel)campus.Vdc, campus.Ward);
        await base.InsertAsync(model);
        return model;
    }

    public async Task<IOrganization> GetByGuidAsync(string name)
    {
        return (await GetQueryable().FirstAsync(x => x.Guid == name));
    }

    public async Task<ICollection<IOrganization>> GetAllAsync()
    {
        return (await base.GetAllAsync()).Cast<IOrganization>().ToList();
    }
}
