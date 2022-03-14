using Mmc.Blog.Entity;
namespace Mmc.Api.Dto;

public class BlogMasterListResponseApiModel
{
    public string Title { get; set; }
    public string Body { get; set; }
    public string Author { get; set; }
    public string Date { get; set; }
}