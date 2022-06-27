using Mmc.Address.Entity;
using Mmc.Data.Model.Address;
using Mmc.User.Entity.Interface;
using UserOrganization = Mmc.User.Entity.Interface.IOrganization;

namespace Mmc.Data.Model.Core;

public class OrganizationModel : UserOrganization
{
    public OrganizationModel()
    {
    }

    public OrganizationModel(string name, string subtitle, CountryModel countryModel, VdcModel vdcModel, StateModel stateModel, int ward)
    {
        Name = name;
        Subtitle = subtitle;
        CountryModel = countryModel;
        VdcModel = vdcModel;
        StateModel = stateModel;
        Ward = ward;
    }

    public long Id { get; protected set; }
    public string Name { get; set; }
    public string Subtitle { get; set; }
    public virtual StateModel StateModel { get; set; }
    IState UserOrganization.State => StateModel;
    public virtual CountryModel CountryModel { get; set; }
    ICountry UserOrganization.Country => CountryModel;
    public virtual VdcModel VdcModel { get; set; }
    IVdc UserOrganization.Vdc => VdcModel;
    public int Ward { get; set; }
}
