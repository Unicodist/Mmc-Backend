using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Configurations.Blog;

public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPostModel>
{
    public void Configure(EntityTypeBuilder<BlogPostModel> builder)
    {
        builder.ToTable("blog_posts");
        builder.HasKey(b => b.Id);
        builder.Property(b => b.Title).HasMaxLength(40);
        builder.Property(b => b.PostedDate).HasDefaultValue(DateTime.Now);
        builder.Property(b => b.AdminId);
        builder.Property(b => b.AuthorName).IsRequired();

        builder.HasOne(b => b.AuthorAdmin).WithMany(u=>u.BlogPosts).HasForeignKey(b=>b.AdminId);
    }
}