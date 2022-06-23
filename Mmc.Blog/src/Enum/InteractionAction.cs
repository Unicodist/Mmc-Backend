namespace Mmc.Blog.Enum;

public class InteractionAction : BaseEnum
{
    private const string _deleteArticle  = "DeleteArticle";
    private const string _likeArticle = "LikeArticle";
    private const string _editArticle = "EditArticle";
    
    private const string _editComment = "EditComment";
    private const string _deleteComment  = "DeleteArticle";

    public static readonly InteractionAction DeleteArticle = new(1, _deleteArticle);
    public static readonly InteractionAction EditArticle = new(2, _editArticle);
    public static readonly InteractionAction LikeArticle = new(2, _likeArticle);
    public static readonly InteractionAction EditComment = new(2, _editComment);
    public static readonly InteractionAction DeleteComment = new(2, _deleteComment);
    
    protected InteractionAction(int id, string? value) : base(id, value)
    {
    }
}