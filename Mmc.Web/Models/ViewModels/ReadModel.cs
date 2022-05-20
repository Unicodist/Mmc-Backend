namespace Mmc.Web.ViewModel;

public class ReadModel
{
    public ReadModel(string title, string body, long viewCount, string author, DateTime postedOn, string imageUrl, string imageAlt, IList<string> tags)
    {
        Title = title;
        Body = body;
        ViewCount = viewCount;
        Author = author;
        PostedOn = postedOn;
        ImageUrl = imageUrl;
        ImageAlt = imageAlt;
        Tags = tags;
    }

    public string Title { get; set; }
    public string Body { get; set; }
    public long ViewCount { get; set; }
    public string Author { get; set; }
    public DateTime PostedOn { get; set; }
    public string ImageUrl { get; set; }
    public string ImageAlt { get; set; }
    public IList<string> Tags { get; set; }
}