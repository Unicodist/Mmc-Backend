using Mmc.Blog.Entity;

namespace Mmc.Core.Repository;

public interface IBlogPostRepository
{
    public Task<IBlogPost> GetById(long id);
    public Task Insert(IBlogPost blogPost);
    public Task<ICollection<IBlogPost>> GetAll();
    IBlogPost CreateInstance(string title, string authorName, string body, DateTime postedDate);
}