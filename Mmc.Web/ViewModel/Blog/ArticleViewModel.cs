namespace Mechi.Backend.ViewModel.Blog;

public class ArticleViewModel
{
    public string Title { get; set; }
    public string? Body { get; set; }
    public DateTime DateTime { get; set; }
    public string Guid { get; set; }
    public string Image { get; set; }
    public string Thumbnail { get; set; }
}
