using Mmc.Address.Entity.Interface;

namespace Mmc.Core.Entity.Interface;

public interface IOrganization
{
    public string Name { get; set; }
    public string BlogSlogan { get; set; }
    public string OrgDistrict { get; set; }
    public string OrgCity { get; set; }
    public string OrgAddress { get; set; }
    public IState State { get; set; }
    public ICountry Country { get; set; }
    public IVdc Vdc { get; set; }
    public int ward { get; set; }
}