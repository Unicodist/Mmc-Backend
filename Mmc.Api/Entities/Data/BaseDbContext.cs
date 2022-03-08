using Microsoft.EntityFrameworkCore;

namespace Mmc.Api.Entities.Data;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<BlogMaster> Blogs { get; set; }
    public DbSet<UserMaster> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            
        }
        base.OnConfiguring(optionsBuilder);
    }
}