namespace Mechi.Backend.ViewModel.Blog;

public class ArticleReadViewModel
{
    public string Title { get; set; }
    public string Date { get; set; }
    public string AuthorName { get; set; }
    public string? Category { get; set; }
    public string? Body { get; set; }
    public string Guid { get; set; }
    public HeartIconViewModel Heart { get; set; }
    public string Thumbnail { get; set; }
}
