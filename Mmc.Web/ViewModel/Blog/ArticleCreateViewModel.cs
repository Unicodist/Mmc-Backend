namespace Mechi.Backend.ViewModel.Blog;

public class ArticleCreateViewModel
{
    public string Title { get; set; } = null!;
    public string? CkEditorBody { get; set; }
    public string? CategoryGuid { get; set; }
    public IFormFile? Thumbnail { get; set; }
}