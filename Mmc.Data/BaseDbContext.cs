using Microsoft.EntityFrameworkCore;
using Mmc.Blog.Entity;
using Mmc.Data.Configurations;
using Mmc.Data.Configurations.Blog;
using Mmc.Data.Configurations.User;
using Mmc.Data.Model;
using Mmc.Notice.Entity;
using Mmc.User.Entity;

namespace Mmc.Data;

public class BaseDbContext : DbContext
{
    private string ConnectionString = "Server=localhost;Database=mmc_core;Uid=root;Pwd=";
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
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new BlogPostConfiguration());
        modelBuilder.ApplyConfiguration(new NoticeConfiguration());
    }
}