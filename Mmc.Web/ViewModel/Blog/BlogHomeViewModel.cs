using Mechi.Backend.ViewModel.Blog;

namespace Mmc.Blog.ViewModel;

public class BlogHomeViewModel
{
    public ArticleViewModel Pinned { get; set; }
    public IEnumerable<ArticleViewModel> Articles { get; set; }
    public int PageCount { get; set; }
}