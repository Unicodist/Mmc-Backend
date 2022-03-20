using Mmc.Data;

namespace Mmc.Blog.ViewModel;

public class LayoutViewModel
{
    public IList<string>? NavigationCategories { get; set; }
    public string CampusName { get; set; } = null!;
    public string CampusSlogan { get; set; } = null!;
}