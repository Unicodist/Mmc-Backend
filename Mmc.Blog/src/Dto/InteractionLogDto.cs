using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Dto;

public class InteractionLogDto
{
    public IComment Comment { get; set; }
    public IArticle Article { get; set; }
    public IBlogUser User { get; set; }
}
