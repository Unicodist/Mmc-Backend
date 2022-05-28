using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class UpvoteModel : IUpvote
{
    public long Id { get; set; }
    public long ArticleId { get; }
    public long UserId { get; }
    
    public virtual UserModel User { get; }
    public virtual ArticleModel Article { get; }

    IBlogUser IUpvote.User => User;
    IArticle IUpvote.Article => Article;
}