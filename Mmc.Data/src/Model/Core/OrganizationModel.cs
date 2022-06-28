using Mmc.Address.Entity.Interface;
using Mmc.Data.Model.Address;
using Mmc.User.BaseType;
using IOrganization = Mmc.Core.Entity.Interface.IOrganization;
using UserOrganization = Mmc.User.Entity.Interface.IOrganization;
using UserCountry = Mmc.User.Entity.Interface.ICountry;
using UserState = Mmc.User.Entity.Interface.IState;
using UserVdc = Mmc.User.Entity.Interface.IVdc;

namespace Mmc.Data.Model.Core;

public class OrganizationModel : UserOrganization, IOrganization
{
    public OrganizationModel()
    {
    }

    public OrganizationModel(string name, string subtitle, VdcModel vdcModel, int ward)
    {
        Name = name;
        Subtitle = subtitle;
        VdcModel = vdcModel;
        Ward = ward;
    }

    public long Id { get; init; }
    public string Guid { get; set; }
    GuidType UserOrganization.Guid => new(Guid);
    Mmc.Core.BaseType.GuidType IOrganization.Guid => new(Guid);
    public string Name { get; set; }
    public string Subtitle { get; set; }
    public virtual VdcModel VdcModel { get; set; }
    UserVdc UserOrganization.Vdc => VdcModel;
    IVdc IOrganization.Vdc => VdcModel;
    public int Ward { get; set; }
    public long VdcId { get; internal set; }
}
