namespace Mmc.Blog.Exception;

public class ArticleNotFoundException : System.Exception
{
    public ArticleNotFoundException() : base("The article is not available"){}
}