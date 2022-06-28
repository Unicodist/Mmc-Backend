using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class BlogUser : IBlogUser
{
    public BlogUser(string name, string userName, IPicture? picture)
    {
        Name = name;
        UserName = userName;
    }

    public long Id { get; }
    public string Name { get; }
    public string UserName { get; }
    public ICollection<IPicture>? Pictures { get; }
    public string GetProfilePicturePath()
    {
        return Pictures.SingleOrDefault(x => x.IsProfilePicture).Location;
    }
}
