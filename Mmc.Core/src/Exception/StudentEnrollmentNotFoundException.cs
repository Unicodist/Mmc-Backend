namespace Mmc.Core.Exception;

public class StudentEnrollmentNotFoundException : System.Exception
{
    public StudentEnrollmentNotFoundException():base("The Enrollment Cannot be found.")
    {
    }

    public StudentEnrollmentNotFoundException(string? message) : base(message)
    {
    }
}
