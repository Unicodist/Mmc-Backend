namespace Mechi.Backend.ViewModel.Blog;

public class BlogHomeViewModel
{
    public ArticleViewModel Pinned { get; set; }
    public IEnumerable<ArticleViewModel> Articles { get; set; }
    public int PageCount { get; set; }
}