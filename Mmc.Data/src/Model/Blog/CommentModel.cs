using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;
using Mmc.Data.Model.User;

namespace Mmc.Data.Model.Blog;

public class CommentModel : IComment
{
    protected CommentModel()
    {
        
    }
    public CommentModel(string body, UserModel user, ArticleModel article, CommentModel parent)
    {
        Body = body;
        User = user;
        Article = article;
        Parent = parent;
    }

    public long Id { get; }
    public string Body { get; set; }
    public long UserId { get; set; }
    public long ArticleId { get; set; }
    public long ParentId { get; set; }
    public Status Status { get; set; }

    public virtual ICollection<CommentModel>? Replies { get; }

    public virtual UserModel User { get; }
    public virtual ArticleModel Article { get; }
    public virtual CommentModel Parent { get; }


    ICollection<IComment> IComment.Replies => Replies.Cast<IComment>().ToList();
    IBlogUser IComment.User => User;
    IArticle IComment.Article => Article;
    IComment IComment.Parent => Parent;
    
    public void Update(string body)
    {
        Body = body;
    }
}