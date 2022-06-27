namespace Mmc.Core.Enum;

public class Semester : BaseEnum
{
    private const string _first  = "First";
    private const string _second = "Inactive";
    private const string _third = "Pending";
    private const string _fourth = "Pending";
    private const string _fifth = "Pending";
    private const string _sixth = "Pending";
    private const string _seventh = "Pending";
    private const string _eighth = "Pending";

    public static readonly Semester First = new(1, _first);
    public static readonly Semester Second = new(2, _second);
    public static readonly Semester Third = new(3, _third);
    public static readonly Semester Fourth = new(4, _fourth);
    public static readonly Semester Fifth = new(5, _fifth);
    public static readonly Semester Sixth = new(6, _sixth);
    public static readonly Semester Seventh = new(7, _seventh);
    public static readonly Semester Eighth = new(8, _eighth);
    
    protected Semester(int id, string? value) : base(id, value)
    {
    }

    public static implicit operator string(Semester sts)
    {
        return sts.ToString();
    }
    public static implicit operator Semester(string str)
    {
        return GetAll<Semester>().SingleOrDefault(x => x.Value == str)!;
    }
}
