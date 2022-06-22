namespace Mmc.Blog.Exception;

public class CommentNotFoundException : System.Exception
{
    public CommentNotFoundException() : base("The comment is either removed or hidden from you"){}
}