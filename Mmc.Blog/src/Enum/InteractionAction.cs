namespace Mmc.Blog.Enum;

public class InteractionType : BaseEnum
{
    private const string _deleteArticle  = "DeleteArticle";
    private const string _likeArticle = "LikeArticle";
    private const string _editArticle = "EditArticle";
    
    private const string _editComment = "EditComment";
    private const string _comment = "Comment";
    private const string _deleteComment  = "DeleteArticle";

    public static readonly InteractionType DeleteArticle = new(1, _deleteArticle);
    public static readonly InteractionType EditArticle = new(2, _editArticle);
    public static readonly InteractionType LikeArticle = new(2, _likeArticle);
    public static readonly InteractionType Comment = new(2, _comment);
    public static readonly InteractionType EditComment = new(2, _editComment);
    public static readonly InteractionType DeleteComment = new(2, _deleteComment);
    
    protected InteractionType(int id, string? value) : base(id, value)
    {
    }
}
