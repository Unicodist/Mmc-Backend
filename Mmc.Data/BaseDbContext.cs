using Microsoft.EntityFrameworkCore;
using Mmc.Data.Configurations;
using Mmc.Data.Configurations.Address;
using Mmc.Data.Configurations.Blog;
using Mmc.Data.Configurations.User;

namespace Mmc.Data;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options)
    {
        
    }

    public BaseDbContext()
    {
        
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