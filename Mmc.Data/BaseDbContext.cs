using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Mmc.Core.Entity;
using Microsoft.Extensions.Configuration;
using Mmc.Data.Configurations;

namespace Mmc.Data;

public class BaseDbContext : DbContext
{
    private IConfiguration _configuration;
    public BaseDbContext(IConfiguration configuration, DbContextOptions<BaseDbContext> options) : base(options)
    {
        _configuration = configuration;
    }

    public BaseDbContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseMySql(_configuration.GetConnectionString("Default"),new MySqlServerVersion(new Version(8,0,28)));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BlogMasterEntryConfiguration());
        modelBuilder.ApplyConfiguration(new UserCredentialsEntryConfiguration());
        modelBuilder.ApplyConfiguration(new UserMasterEntryConfiguration());
    }

    public DbSet<UserCredentials> UserCredentials { get; set; }
    public DbSet<UserMaster> UserMasters { get; set; }
    public DbSet<BlogMaster> BlogMasters { get; set; }
}