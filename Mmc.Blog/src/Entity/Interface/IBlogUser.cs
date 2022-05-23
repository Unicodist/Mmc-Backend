namespace Mmc.Blog.Entity.Interface;

public interface IBlogUser
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string UserName { get; set; }
}