namespace Mmc.Blog.Enum;

public class InteractionAction : BaseEnum
{
    private const string _delete  = "Delete";
    private const string _like = "Like";
    private const string _edit = "Edit";

    public static readonly InteractionAction Delete = new InteractionAction(1, _delete);
    public static readonly InteractionAction Edit = new InteractionAction(2, _edit);
    public static readonly InteractionAction Like = new InteractionAction(2, _like);
    
    protected InteractionAction(int id, string? value) : base(id, value)
    {
    }
}