using Microsoft.EntityFrameworkCore;

namespace Mmc.Api.Entities.Data;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<BlogEntity> Blogs { get; set; }
    public DbSet<UserEntity> Users { get; set; }
}