using Mmc.Blog.Entity;

namespace Mmc.Blog.Repository;

public interface IBlogPostRepository
{
    public Task<IArticle> GetById(long id);
    public Task Insert(IArticle article);
    public Task<ICollection<IArticle>> GetAll();
    IArticle CreateInstance(string title, string authorName, string body, DateTime postedDate);
}