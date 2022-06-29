namespace Mmc.Blog.Exception;

public class CategoryNotFoundException : System.Exception
{
    public CategoryNotFoundException() : base("The category is not available"){}
}
