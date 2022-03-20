using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity;
using Mmc.Data.Configurations;
using Mmc.Notice.Entity;
using Mmc.User.Entity;

namespace Mmc.Data;

public class BaseDbContext : DbContext
{
    private string ConnectionString = "Server=localhost;Database=mmc_core;Uid=root;Pwd=(**)&^(()&Ashish;";
    public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
    {
        
    }

    public BaseDbContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseMySql(ConnectionString, new MySqlServerVersion(new Version(8,0,24)));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMasterEntryConfiguration());
        modelBuilder.ApplyConfiguration(new BlogMasterEntryConfiguration());
        modelBuilder.ApplyConfiguration(new NoticeMasterEntryConfiguration());
    }

    public DbSet<UserMasterEntity> UserMasters { get; set; }
    public DbSet<BlogMasterEntity> BlogMasters { get; set; }
    public DbSet<NoticeMasterEntity> NoticeMasters { get; set; }
}