using Mmc.Blog.Entity.Interface;
using Mmc.Notice.Entity.Interface;
using Mmc.User.Entity.Interface;
using Mmc.User.Enum;
using IPicture = Mmc.Blog.Entity.Interface.IPicture;

namespace Mmc.Data.Model.User;
public class UserModel: IUser,
    IBlogUser,
    INoticeUser
{
    public UserModel(string name, string userType, string email, string password, string userName,Mmc.User.Entity.Interface.IPicture picture)
    {
        Name = name;
        UserType = userType;
        Email = email;
        Password = password;
        UserName = userName;
        Picture = (PictureModel)picture;
    }

    public UserModel()
    {
        
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public string UserType { get; set; }
    UserType IUser.UserType => UserType;
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
    public virtual PictureModel Picture { get; set; }
    IPicture IBlogUser.Picture => Picture;
    Mmc.User.Entity.Interface.IPicture IUser.Picture => Picture;
    public long PictureId { get; set; }

    public void MakeAdmin()
    {
        UserType = Mmc.User.Enum.UserType.ADMIN;
    }

    public void MakeUser()
    {
        UserType = Mmc.User.Enum.UserType.USER;
    }
}
