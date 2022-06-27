namespace Mmc.Core.Enum;

public class StudentEnrollmentStatus : BaseEnum
{
    private const string _active  = "Active";
    private const string _dropped = "Dropped";
    private const string _transfered = "Transfered";
    private const string _passedOut = "Passed Out";

    public static readonly StudentEnrollmentStatus Active = new(1, _active);
    public static readonly StudentEnrollmentStatus Dropped = new(2, _dropped);
    public static readonly StudentEnrollmentStatus Transfered = new(3, _transfered);
    public static readonly StudentEnrollmentStatus PassedOut = new(4, _passedOut);
    
    protected StudentEnrollmentStatus(int id, string? value) : base(id, value)
    {
    }

    public static implicit operator string(StudentEnrollmentStatus sts)
    {
        return sts.ToString();
    }
    public static implicit operator StudentEnrollmentStatus(string str)
    {
        return GetAll<StudentEnrollmentStatus>().SingleOrDefault(x => x.Value == str)!;
    }
}
