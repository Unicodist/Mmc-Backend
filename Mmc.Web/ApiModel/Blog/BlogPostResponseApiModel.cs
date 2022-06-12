namespace Mechi.Backend.ApiModel.Blog;

public class BlogPostResponseApiModel
{
    public BlogPostResponseApiModel(string title, string? body, string author, string date, string guid, string picture)
    {
        Title = title;
        Body = body;
        Author = author;
        Date = date;
        Guid = guid;
        Picture = picture;
    }

    public string Title { get; set; }
    public string Guid { get; set; }
    public string Picture { get; set; }
    public string? Body { get; set; }
    public string Author { get; set; }
    public string Date { get; set; }
}