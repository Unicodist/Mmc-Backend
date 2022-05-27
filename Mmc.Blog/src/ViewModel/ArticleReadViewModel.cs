using System.Collections;

namespace Mmc.Blog.ViewModel;

public class ArticleReadViewModel
{
    public string Title { get; set; }
    public string Date { get; set; }
    public string AuthorName { get; set; }
    public string? Categories { get; set; }
    public string Body { get; set; }
}