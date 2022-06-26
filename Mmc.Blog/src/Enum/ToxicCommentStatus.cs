namespace Mmc.Blog.Enum;

public class ToxicCommentStatus : BaseEnum
{
    private const string _active  = "Active";
    private const string _removed = "Removed";
    private const string _cleared = "Clear";

    public static readonly ToxicCommentStatus Active = new(1, _active);
    public static readonly ToxicCommentStatus Removed = new(2, _removed);
    public static readonly ToxicCommentStatus Cleared = new(2, _cleared);
    
    protected ToxicCommentStatus(int id, string? value) : base(id, value)
    {
    }
}
