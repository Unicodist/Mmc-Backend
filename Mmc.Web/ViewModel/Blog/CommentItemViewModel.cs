namespace Mmc.Blog.ViewModel;

public class CommentItemViewModel
{
    public string Guid { get; set; }
    public string Body { get; set; } 
    public string picture { get; set; } = "https://dummyimage.com/50x50/ced4da/6c757d.jpg";
    public string Name { get; set; }
    public bool SelfComment { get; set; }
}