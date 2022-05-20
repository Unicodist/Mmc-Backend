namespace Mmc.Blog.ApiResponseModel.Blog;

public class BlogPostResponseApiModel
{
    public BlogPostResponseApiModel(string title, string body, string author, string date)
    {
        Title = title;
        Body = body;
        Author = author;
        Date = date;
    }

    public string Title { get; set; }
    public string Body { get; set; }
    public string Author { get; set; }
    public string Date { get; set; }
}