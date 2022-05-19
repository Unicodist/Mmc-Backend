using Microsoft.EntityFrameworkCore;
using Mmc.Data.Configurations;
using Mmc.Data.Configurations.Address;
using Mmc.Data.Configurations.Blog;
using Mmc.Data.Configurations.User;

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
        #region Blog

        modelBuilder.ApplyConfiguration(new BlogPostConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        #endregion

        #region Notice

        modelBuilder.ApplyConfiguration(new NoticeConfiguration());

        #endregion

        #region User

        modelBuilder.ApplyConfiguration(new UserConfiguration());

        #endregion

        #region Address

        modelBuilder.ApplyConfiguration(new CountryConfiguration());
        modelBuilder.ApplyConfiguration(new StateConfiguration());
        modelBuilder.ApplyConfiguration(new VdcConfiguration());

        #endregion
        
    }
}