using Mmc.Blog.Entity.Interface;

namespace Mmc.Blog.Repository;

public interface ICategoryRepository
{
    public Task<ICategory?> GetById(long id);
    public Task Insert(ICategory category);
    public Task<ICollection<ICategory>?> GetAll();
    ICategory CreateInstance(string name, string description);
}