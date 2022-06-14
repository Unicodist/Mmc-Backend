namespace Mechi.Backend.ViewModel.Blog;

public class ArticleCreateViewModel
{
    public string Title { get; set; }
    public string? CkEditorBody { get; set; }
    public string? CategoryGuid { get; set; }
}