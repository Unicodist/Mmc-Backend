using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Blog.Enum;
using Mmc.Data.Model.Blog;
using Mmc.Data.TypeConverter.Blog;

namespace Mmc.Data.Configurations.Blog;

public class CategorySubscriptionConfiguration : IEntityTypeConfiguration<CategorySubscriptionModel>
{
    public void Configure(EntityTypeBuilder<CategorySubscriptionModel> builder)
    {
        _ = builder.ToTable("category_subscription");
        _ = builder.HasKey(a => a.UserId);
        _ = builder.HasKey(a => a.CategoryId);
        _ = builder.Property(a => a.UserId).HasColumnName("user_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.CategoryId).HasColumnName("category_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Status).HasColumnName("status").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).HasConversion(new EnumConverter<Status>());

        _ = builder.HasOne(a => a.Category).WithMany().HasForeignKey(a => a.CategoryId);
        _ = builder.HasOne(a => a.User).WithMany().HasForeignKey(a => a.UserId);
    }
}