using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mmc.Data.Configurations.Address;
using Mmc.Data.Configurations.Blog;
using Mmc.Data.Configurations.Core;
using Mmc.Data.Configurations.Notice;
using Mmc.Data.Configurations.User;

namespace Mmc.Data;

public class  AppDbContext : DbContext
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
        modelBuilder.ApplyConfiguration(new KeyValConfiguration());
        #region Blog

        _ = modelBuilder.ApplyConfiguration(new ArticleConfiguration());
        _ = modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        _ = modelBuilder.ApplyConfiguration(new CommentConfiguration());
        _ = modelBuilder.ApplyConfiguration(new UpvoteConfiguration());
        _ = modelBuilder.ApplyConfiguration(new InteractionLogConfiguration());
        _ = modelBuilder.ApplyConfiguration(new CategorySubscriptionConfiguration());

        #endregion

        #region Notice

        _ = modelBuilder.ApplyConfiguration(new NoticeConfiguration());

        #endregion

        #region User

        _ = modelBuilder.ApplyConfiguration(new UserConfiguration());
        _ = modelBuilder.ApplyConfiguration(new NotificationConfiguration());
        _ = modelBuilder.ApplyConfiguration(new NotificationTemplateConfiguration());
        _ = modelBuilder.ApplyConfiguration(new PictureConfiguration());

        #endregion

        #region Address

        _ = modelBuilder.ApplyConfiguration(new CountryConfiguration());
        _ = modelBuilder.ApplyConfiguration(new StateConfiguration());
        _ = modelBuilder.ApplyConfiguration(new VdcConfiguration());

        #endregion
        
    }
}
