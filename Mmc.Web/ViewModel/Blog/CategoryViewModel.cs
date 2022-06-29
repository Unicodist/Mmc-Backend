namespace Mechi.Backend.ViewModel.Blog;

public class CategoryViewModel
{
    public string? Guid { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool IsNew { get; set; }

    public static CategoryViewModel GetNew()
    {
        return new CategoryViewModel() {IsNew = true};
    }
}
