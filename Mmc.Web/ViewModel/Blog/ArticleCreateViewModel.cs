namespace Mmc.Blog.ViewModel;

public class ArticleCreateViewModel
{
    public string Title { get; set; } = null!;
    public string CkEditorBody { get; set; }
    public string CategoryGuid { get; set; }
}