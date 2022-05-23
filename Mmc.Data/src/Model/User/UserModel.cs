using Mmc.Data.Model.Blog;
using Mmc.Data.Model.Notice;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;

namespace Mmc.Data.Model.User;
public class UserModel: IUser, Mmc.Blog.Entity.Interface.IBlogUser,Mmc.Notice.Entity.Interface.INoticeUser
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public string UserType { get; set; }
    UserType IUser.UserType => UserType;
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public virtual ICollection<ArticleModel> BlogPosts { get; set; }
    public virtual ICollection<NoticeModel> Notices { get; set; }
}