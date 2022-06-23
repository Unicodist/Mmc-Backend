using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class BlogUser : IBlogUser
{
    public BlogUser(string name, string userName, IPicture picture)
    {
        Name = name;
        UserName = userName;
        Picture = picture;
    }

    public long Id { get; }
    public string Name { get; }
    public string UserName { get; }
    public IPicture Picture { get; }
}
