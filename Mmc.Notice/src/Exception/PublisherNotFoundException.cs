namespace Mmc.Notice.Exception;

public class PublisherNotFoundException : System.Exception
{
    public PublisherNotFoundException() : base("Such Notice Publisher doesn't exist.")
    {
    }

    public PublisherNotFoundException(string? message) : base(message)
    {
    }
}
