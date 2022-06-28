namespace Mmc.Blog.Entity.Interface;

public interface IBlogUser
{
    public long Id { get; }
    string Name { get; }
    string UserName { get; }
    ICollection<IPicture>? Pictures { get; }
    string GetProfilePicturePath();
}
