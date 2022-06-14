using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;
using Mmc.Data.Model.User;
using Mmc.User.Entity.Interface;

namespace Mmc.Data.Model.Blog;

public class CategorySubscriptionModel : ICategorySubscription
{
    public CategorySubscriptionModel()
    {
    }

    public CategorySubscriptionModel(IBlogUser csUser, ICategory csCategory)
    {
        Category = (CategoryModel) csCategory;
        User = (UserModel) csUser;
    }

    public long Id { get; protected set; }
    public long UserId { get; protected set; }
    public long CategoryId { get; protected set; }
    public Status Status { get; set; }
    public bool IsActive() => Status == Status.Active;

    public virtual UserModel User { get; set; }
    IBlogUser ICategorySubscription.User => User;
    public virtual CategoryModel Category { get; set; }
    ICategory ICategorySubscription.Category => Category;
}