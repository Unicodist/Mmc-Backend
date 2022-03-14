using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Notice.Entity;

namespace Mmc.Data.Configurations
{
    internal class NoticeMasterEntryConfiguration : IEntityTypeConfiguration<NoticeMaster>
    {
        public void Configure(EntityTypeBuilder<NoticeMaster> builder)
        {
            builder.ToTable("notice_master");
            builder.HasKey(n => n.NoticeMasterId);
            builder.Property(n => n.NoticeMasterId).HasColumnName("notice_master_id");
            builder.Property(n => n.NoticeMasterTitle).HasColumnName("notice_master_title");
            builder.Property(n => n.NoticeMasterBody).HasColumnName("notice_master_body");
            builder.Property(n => n.PostedOn).HasColumnName("notice_master_posted_date");
            builder.Property(n => n.NoticeMasterNoticePicture).HasColumnName("notice_master_picture");

            builder.HasOne(n => n.NoticeMasterAuthor).WithMany(u => u.Notices);
        }
    }
}
