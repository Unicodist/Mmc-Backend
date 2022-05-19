using Mmc.Data.Model.Address;

namespace Mmc.Core.Entity;

public class OrganizationModel

{
    public string Name { get; set; }
    public StateModel State { get; set; }
    public string OrgBlogTitle { get; set; }
    public string BlogSlogan { get; set; }
    public string OrgDistrict { get; set; }
    public string OrgCity { get; set; }
    public string OrgAddress { get; set; }
}