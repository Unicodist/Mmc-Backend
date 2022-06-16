namespace Mmc.Blog.Entity.Interface;

public interface IBlogUser
{
    public long Id { get; }
    string Name { get; }
    string UserName { get; }

    string? picture { get; }
}