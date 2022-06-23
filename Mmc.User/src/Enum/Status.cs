namespace Mmc.User.Enum;

public class Status : BaseEnum
{
    public static readonly Status ACTIVE = new(1, Active);
    public static readonly Status INACTIVE = new(2, Inactive);
    private const string Active = "Active";
    private const string Inactive = "Inactive";

    private Status(int id, string value): base(id, value)
    {
        
    }
    public static implicit operator string(Status value)=>value.ToString();
    public static implicit operator Status(string value)=>GetAll<Status>().SingleOrDefault(x => x.ToString() == value)??ACTIVE;
}