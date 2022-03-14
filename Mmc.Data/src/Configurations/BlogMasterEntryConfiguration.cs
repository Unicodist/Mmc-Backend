using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Blog.Entity;

namespace Mmc.Data.Configurations;

public class BlogMasterEntryConfiguration : IEntityTypeConfiguration<BlogMaster>
{
    public void Configure(EntityTypeBuilder<BlogMaster> builder)
    {
        builder.ToTable("blog_master");
        builder.HasKey(b => b.BlogMasterId);
        builder.Property(b => b.BlogMasterId).HasColumnName("blog_master_id");
        builder.Property(b => b.BlogMasterTitle).HasColumnName("blog_master_title").HasMaxLength(40);
        builder.Property(b => b.BlogMasterBody).HasColumnName("blog_master_body");
        builder.Property(b => b.BlogMasterAuthorAdminId).HasColumnName("blog_master_author_id");
        builder.Property(b => b.BlogMasterPostedDate).HasColumnName("blog_master_posted_date");
        builder.Property(b => b.BlogMasterAuthorName).HasColumnName("blog_master_author_name");

        builder.HasOne(b => b.BlogMasterAuthorAdmin).WithMany(u=>u.Blogs).HasForeignKey(b=>b.BlogMasterAuthorAdminId);
    }
}