using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Configurations.Blog;

public class ArticleConfiguration : IEntityTypeConfiguration<ArticleModel>
{
    public void Configure(EntityTypeBuilder<ArticleModel> builder)
    {
        builder.ToTable("blog_posts");
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("blog_id").HasColumnType(ColumnTypes.BIGINT);
        builder.Property(b => b.Title).HasColumnName("title").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(40).IsRequired();
        builder.Property(b => b.PostedDate).HasColumnName("posted_date").HasDefaultValue(DateTime.Now);
        builder.Property(b => b.AdminId).HasColumnName("admin_id").HasColumnType(ColumnTypes.BIGINT);
        builder.Property(b => b.AuthorName).IsRequired();

        builder.HasOne(b => b.AuthorAdmin).WithMany(u=>u.BlogPosts).HasForeignKey(b=>b.AdminId);
        builder.HasOne(b => b.Category).WithMany(u=>u.BlogPosts).HasForeignKey(b=>b.CategoryId);
    }
}