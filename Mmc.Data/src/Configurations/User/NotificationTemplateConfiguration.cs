using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.User.Entity;

namespace Mmc.Data.Configurations.User;

public class NotificationTemplateConfiguration : IEntityTypeConfiguration<NotificationTemplate>
{
    public void Configure(EntityTypeBuilder<NotificationTemplate> builder)
    {
        _ = builder.ToTable("notification_template");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("notificatoin_template_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.Title).HasColumnName("title").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50);
        _ = builder.Property(a => a.Body).HasColumnName("body").HasColumnType(ColumnTypes.Varchar).HasMaxLength(100);
    }
}