using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model;
using Mmc.Data.Model.Notice;
using Mmc.Notice.Entity;
using Mmc.User.Entity;

namespace Mmc.Data.Configurations
{
    internal class NoticeConfiguration : IEntityTypeConfiguration<NoticeModel>
    {
        public void Configure(EntityTypeBuilder<NoticeModel> builder)
        {
            builder.ToTable("notice");
            builder.HasKey(n => n.NoticeMasterId);
            builder.Property(n => n.NoticeMasterTitle).IsRequired();
            builder.Property(n => n.NoticeMasterBody).IsRequired();
            builder.Property(n => n.NoticeMasterAuthorId).IsRequired();
            builder.Property(n => n.PostedOn).HasDefaultValue(DateTime.Now);
            builder.Property(n => n.NoticeMasterNoticePicture);

            builder.HasOne(n => n.NoticeMasterEntityAuthor)
                .WithMany(u => u.Notices)
                .HasForeignKey(n=>n.NoticeMasterAuthorId);
        }
    }
}
