namespace Mmc.Notice.Exception;

public class NoticeNotFoundException : System.Exception
{
    public NoticeNotFoundException() : base("The notice cannot be found in the database")
    {
    }

    public NoticeNotFoundException(string? message) : base(message)
    {
    }
}