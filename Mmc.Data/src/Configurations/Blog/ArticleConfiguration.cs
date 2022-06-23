using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Blog.BaseType;
using Mmc.Data.Model.Blog;
using Mmc.Data.TypeConverter.Blog;

namespace Mmc.Data.Configurations.Blog;

public class ArticleConfiguration : IEntityTypeConfiguration<ArticleModel>
{
    public void Configure(EntityTypeBuilder<ArticleModel> builder)
    {
        builder.ToTable("blog_posts");
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("blog_id").HasColumnType(ColumnTypes.BIGINT);
        builder.Property(b => b.Title).HasColumnName("title").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(40).IsRequired();
        builder.Property(b => b.Body).HasColumnName("Body").HasColumnType(ColumnTypes.TEXT).IsRequired();
        builder.Property(b => b.PostedDate).HasColumnName("posted_date").HasColumnType(ColumnTypes.DATE);
        builder.Property(b => b.PostedTime).HasColumnName("posted_time").HasColumnType(ColumnTypes.TIME);
        builder.Property(b => b.UserId).HasColumnName("admin_id").HasColumnType(ColumnTypes.BIGINT);
        builder.Property(b => b.CategoryId).HasColumnName("category_id").HasColumnType(ColumnTypes.BIGINT);
        builder.Property(b => b.Thumbnail).HasColumnName("thumbnail").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(150);
        builder.Property(b => b.Guid).HasColumnName("guid").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).HasConversion(new BaseTypeStringConverter<GuidType>());

        builder.HasOne(b => b.AuthorAdmin).WithMany().HasForeignKey(b=>b.UserId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(b => b.Category).WithMany(u=>u.BlogPosts).HasForeignKey(b=>b.CategoryId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(b => b.Interactions).WithOne(u=>u.Article).HasForeignKey(b=>b.ArticleId).OnDelete(DeleteBehavior.Cascade);
    }
}
