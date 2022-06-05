using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Entity;

public class BlogUser : IBlogUser
{
    public BlogUser(string name, string userName, string picture)
    {
        Name = name;
        UserName = userName;
        this.picture = picture;
    }

    public long Id { get; }
    public string Name { get; }
    public string UserName { get; }
    public string picture { get; }
}