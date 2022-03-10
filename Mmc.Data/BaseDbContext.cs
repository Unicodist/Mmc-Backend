using Microsoft.EntityFrameworkCore;
using Mmc.Core.Entity;
using Microsoft.Extensions.Configuration;

namespace Mmc.Data;

public class BaseDbContext : DbContext
{
    public BaseDbContext(IConfiguration config, DbContextOptions options) : base(options)
    {
    }

    public BaseDbContext()
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