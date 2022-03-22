using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Blog.Entity;

namespace Mmc.Data.Configurations;

public class BlogMasterEntryConfiguration : IEntityTypeConfiguration<BlogMasterEntity>
{
    public void Configure(EntityTypeBuilder<BlogMasterEntity> builder)
    {
        builder.ToTable("blog_master");
        builder.HasKey(b => b.BlogMasterId);
        builder.Property(b => b.BlogMasterTitle).HasMaxLength(40);
        builder.Property(b => b.BlogMasterPostedDate).HasDefaultValue(DateTime.Now);
        builder.Property(b => b.BlogMasterAuthorAdminId);
        builder.Property(b => b.BlogMasterAuthorName).IsRequired();

        builder.HasOne(b => b.BlogMasterEntityAuthorAdmin).WithMany(u=>u.Blogs).HasForeignKey(b=>b.BlogMasterAuthorAdminId);
    }
}