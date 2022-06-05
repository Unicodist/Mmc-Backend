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
        builder.Property(b => b.Id).HasColumnName("blog_id").HasColumnType(ColumnTypes.Bigint);
        builder.Property(b => b.Title).HasColumnName("title").HasColumnType(ColumnTypes.Varchar).HasMaxLength(40).IsRequired();
        builder.Property(b => b.Body).HasColumnName("Body").HasColumnType(ColumnTypes.Varchar).HasMaxLength(40).IsRequired();
        builder.Property(b => b.PostedDate).HasColumnName("posted_date").HasDefaultValue(DateTime.Now);
        builder.Property(b => b.AdminId).HasColumnName("admin_id").HasColumnType(ColumnTypes.Bigint);
        builder.Property(b => b.CategoryId).HasColumnName("CategoryId").HasColumnType(ColumnTypes.Bigint);
        builder.Property(b => b.AuthorName).IsRequired();

        builder.HasOne(b => b.AuthorAdmin).WithMany(u=>u.BlogPosts).HasForeignKey(b=>b.AdminId).OnDelete(DeleteBehavior.Cascade);
        builder.HasOne(b => b.Category).WithMany(u=>u.BlogPosts).HasForeignKey(b=>b.CategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}