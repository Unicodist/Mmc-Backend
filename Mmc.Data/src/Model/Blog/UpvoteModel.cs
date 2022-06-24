using Mmc.Blog.Entity.Interface;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class UpvoteModel : IUpvote
{
    public UpvoteModel()
    {
    }

    public UpvoteModel(UserModel user, ArticleModel article)
    {
        User = user;
        Article = article;
    }

    public long ArticleId { get; }
    public long UserId { get; }
    
    public virtual UserModel User { get; }
    public virtual ArticleModel Article { get; }

    IBlogUser IUpvote.User => User;
    IArticle IUpvote.Article => Article;
}
