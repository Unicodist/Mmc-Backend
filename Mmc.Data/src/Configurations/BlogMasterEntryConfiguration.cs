using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Core.Entity;

namespace Mmc.Data.Configurations;

public class BlogMasterEntryConfiguration : IEntityTypeConfiguration<BlogMaster>
{
    public void Configure(EntityTypeBuilder<BlogMaster> builder)
    {
        builder.ToTable("blog_master");
        builder.HasKey(b => b.BlogMasterId);
        builder.Property(b => b.BlogMasterId).HasColumnType("INT(11)");
        builder.Property(b => b.BlogMasterTitle).HasColumnType("varchar").HasMaxLength(40);
        builder.Property(b => b.BlogMasterBody).HasColumnType("TEXT");
        builder.Property(b => b.BlogMasterAuthorAdminId).HasColumnType("INT(11)");
        builder.Property(b => b.BlogMasterPostedDate).HasColumnType("DATE");
        builder.Property(b => b.BlogMasterAuthorName).HasColumnType("VARCHAR(30)");

        builder.HasOne(b => b.BlogMasterAuthorAdmin).WithMany(u => u.Blogs).HasForeignKey("fk_blogmaster_adminid_usermaster");
    }
}