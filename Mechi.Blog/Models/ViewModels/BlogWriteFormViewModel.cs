namespace Mmc.Blog.ViewModel;

public class BlogWriteFormViewModel : LayoutViewModel
{
    public string Title { get; set; } = null!;
    public string? Body { get; set; }
}