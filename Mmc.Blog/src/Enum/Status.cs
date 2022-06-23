namespace Mmc.Blog.Enum;

public class Status : BaseEnum
{
    private const string _active  = "Active";
    private const string _inactive = "Inactive";
    private const string _pending = "Pending";

    public static readonly Status Active = new(1, _active);
    public static readonly Status Inactive = new(2, _inactive);
    public static readonly Status Pending = new(2, _pending);
    
    protected Status(int id, string? value) : base(id, value)
    {
    }
}