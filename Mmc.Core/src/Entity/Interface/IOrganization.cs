namespace Mmc.Core.Entity.Interface;

public interface IOrganization
{
    public string OrganizationName { get; set; }
    public string OrganizationSubtitle { get; set; }
    public string OrganizationState { get; set; }
    public string OrganizationCountry { get; set; }
    public string OrganizationVdc { get; set; }
    public string OrganizationWard { get; set; }
}