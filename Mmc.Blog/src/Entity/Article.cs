using Mmc.Blog.BaseType;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;

namespace Mmc.Blog.Entity;

public class Article : IArticle
{
    public Article(string title, string? body, DateOnly someDate, ICategory? category, IBlogUser blogUser, string? thumbnail)
    {
        Title = title;
        Body = body;
        Category = category;
        User = blogUser;
        Thumbnail = thumbnail;
        Guid = new GuidType();
        PostedDate = someDate;
    }

    public long Id { get; }
    public string Title { get; set; }
    public string? Body { get; set; }
    public DateOnly PostedDate { get; }
    public TimeOnly PostedTime { get; set; }
    public string? Thumbnail { get; }
    public GuidType Guid { get; }
    public long UserId => User.Id;
    public long? CategoryId => Category?.Id;
    public IBlogUser User { get; }
    public ICategory? Category { get; set; }
    public ICollection<IUpvote> Likes { get; }
    public ICollection<IInteractionLog> Interactions { get; set; }
    

    public void Update(string dtoTitle, string? dtoBody, ICategory category)
    {
        Title = dtoTitle;
        Body = dtoBody;
        Category = category;
    }

    public int GetLikesCount()
    {
        return Interactions.Count(x => x.InteractionType == InteractionType.LikeArticle);
    }
}
