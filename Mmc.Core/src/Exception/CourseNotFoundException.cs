namespace Mmc.Core.Exception;

public class CourseNotFoundException : System.Exception
{
    public CourseNotFoundException():base("The course is not available")
    {
    }

    public CourseNotFoundException(string? message) : base(message)
    {
    }
}
