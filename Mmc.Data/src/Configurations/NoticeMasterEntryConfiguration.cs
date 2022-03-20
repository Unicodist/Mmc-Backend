using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Notice.Entity;
using Mmc.User.Entity;

namespace Mmc.Data.Configurations
{
    internal class NoticeMasterEntryConfiguration : IEntityTypeConfiguration<NoticeMasterEntity>
    {
        public void Configure(EntityTypeBuilder<NoticeMasterEntity> builder)
        {
            builder.ToTable("notice_master");
            builder.HasKey(n => n.NoticeMasterId);
            builder.Property(n => n.NoticeMasterTitle).IsRequired();
            builder.Property(n => n.NoticeMasterBody).IsRequired();
            builder.Property(n => n.PostedOn).HasDefaultValue(DateTime.Now);
            builder.Property(n => n.NoticeMasterNoticePicture);

            builder.HasOne(n => n.NoticeMasterEntityAuthor)
                .WithMany(u => u.Notices)
                .HasForeignKey(n=>n.NoticeMasterAuthorId);
        }
    }
}
