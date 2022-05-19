using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Blog.Enum;
using Mmc.Data.Model.Blog;
using Mmc.Data.TypeConverter;

namespace Mmc.Data.Configurations.Blog;

public class CategoryConfiguration : IEntityTypeConfiguration<CategoryModel>
{
    public void Configure(EntityTypeBuilder<CategoryModel> builder)
    {
        _ = builder.ToTable("category");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("category_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Name).HasColumnName("name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Description).HasColumnName("description").HasColumnType(ColumnTypes.TEXT);
        _ = builder.Property(a => a.Status).HasColumnName("status").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(20).HasConversion(new BaseTypeStringConverter<Status>());

        _ = builder.HasMany(a => a.BlogPosts).WithOne(b => b.Category).HasForeignKey(b => b.CategoryId);
    }
}