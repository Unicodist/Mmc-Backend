using Mmc.Data.Model.Blog;
using Mmc.Data.Model.Notice;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;

namespace Mmc.Data.Model.User;
public class UserModel: IUser, Mmc.Blog.Entity.Interface.IUser
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public UserType UserType { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }

    public ICollection<BlogPostModel> BlogPosts { get; set; }
    public ICollection<NoticeModel> Notices { get; set; }


    public void SetPassword(string password)
    {
        Password = password;
    }
}