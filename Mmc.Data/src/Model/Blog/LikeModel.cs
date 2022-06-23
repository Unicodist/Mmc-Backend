using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class LikeModel : ILike
{
    public long Id { get; }
    public long UserId { get; }
    public long ArticleId { get; }
    public virtual ArticleModel Article { get; }
    IArticle ILike.Article => Article;
    public virtual UserModel User { get; }
    IBlogUser ILike.User => User;

}
