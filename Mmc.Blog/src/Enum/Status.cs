namespace Mmc.Blog.Enum;

public class Status : BaseEnum
{
    private const string _active  = "Active";
    private const string _inactive = "Inactive";

    public static readonly Status Active = new Status(1, _active);
    public static readonly Status Inactive = new Status(2, _inactive);
    
    protected Status(int id, string? value) : base(id, value)
    {
    }
}