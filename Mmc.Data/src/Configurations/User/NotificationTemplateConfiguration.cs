using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model;
using Mmc.User.Entity;

namespace Mmc.Data.Configurations.User;

public class NotificationTemplateConfiguration : IEntityTypeConfiguration<NotificationTemplateModel>
{
    private readonly ICollection<NotificationTemplateModel> _templates = new List<NotificationTemplateModel>()
    {
        new NotificationTemplateModel("Review Comment","System has detected a bad comment from {0}. Please review it"){Id=1}
    };
    public void Configure(EntityTypeBuilder<NotificationTemplateModel> builder)
    {
        _ = builder.ToTable("notification_template");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("notificatoin_template_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Title).HasColumnName("title").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Body).HasColumnName("body").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(100);

        _ = builder.HasData(_templates);
    }
}
