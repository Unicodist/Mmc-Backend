namespace Mmc.Notice.Exception;

public class UnknownSeverityLevelException : System.Exception
{
    public UnknownSeverityLevelException() : base("The severity level is not defined. Please try again.")
    {
    }

    public UnknownSeverityLevelException(string? message) : base(message)
    {
    }
}
