namespace Mechi.Blog.ViewModel;

public class ReadModel
{
    public string Title { get; set; }
    public string Body { get; set; }
    public long viewCount { get; set; }
    public string Author { get; set; }
    public DateTime PostedOn { get; set; }
    public string ImageUrl { get; set; }
    public string ImageAlt { get; set; } = "Head Picture of the blog";
    public IList<string> Tags { get; set; }
}