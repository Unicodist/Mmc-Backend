using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mmc.Data.Configurations;
using Mmc.Data.Configurations.Address;
using Mmc.Data.Configurations.Blog;
using Mmc.Data.Configurations.User;
using MySqlConnector;

namespace Mmc.Data;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("Default");
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Blog

        modelBuilder.ApplyConfiguration(new ArticleConfiguration());
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