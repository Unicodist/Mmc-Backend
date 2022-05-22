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
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Title).IsRequired();
            builder.Property(n => n.Body).IsRequired();
            builder.Property(n => n.AdminId).IsRequired();
            builder.Property(n => n.PostedOn).HasDefaultValue(DateTime.Now);
            builder.Property(n => n.Picture);

            builder.HasOne(n => n.Author)
                .WithMany(u => u.Notices)
                .HasForeignKey(n=>n.AdminId);
        }
    }
}
