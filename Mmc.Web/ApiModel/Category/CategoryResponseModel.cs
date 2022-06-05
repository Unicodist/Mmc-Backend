using Mmc.Blog.BaseType;

namespace Mechi.Backend.ApiModel.Category;

public class CategoryResponseModel
{
    public GuidType Guid { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}