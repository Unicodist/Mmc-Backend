using Mmc.Address.Entity.Interface;
using UserCountry = Mmc.User.Entity.Interface.ICountry;
using UserState = Mmc.User.Entity.Interface.IState;
using UserVdc = Mmc.User.Entity.Interface.IVdc;

namespace Mmc.Data.Model.Address;

public class VdcModel : IVdc,UserVdc
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public long StateId { get; set; }
    public virtual StateModel StateModel { get; set; }
    IState IVdc.State => StateModel;
    UserState UserVdc.State => StateModel;
}
