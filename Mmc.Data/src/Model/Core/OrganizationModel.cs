using Mmc.Core.Entity.Interface;

namespace Mmc.Data.Model.Core;

public class OrganizationModel : IOrganization
{
    public OrganizationModel(string name, string subtitle, string country, string vdc, string state, string ward)
    {
        OrganizationName = name;
        OrganizationSubtitle = subtitle;
        OrganizationCountry = country;
        OrganizationVdc = vdc;
        OrganizationState = state;
        OrganizationWard = ward;
    }

    public string OrganizationName { get; set; }
    public string OrganizationSubtitle { get; set; }
    public string OrganizationState { get; set; }
    public string OrganizationCountry { get; set; }
    public string OrganizationVdc { get; set; }
    public string OrganizationWard { get; set; }
}