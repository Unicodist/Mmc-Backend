using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.User;
using Mmc.Data.TypeConverter.User;
using Mmc.User.Enum;

namespace Mmc.Data.Configurations.User;

public class NotificationConfiguration : IEntityTypeConfiguration<NotificationModel>
{
    public void Configure(EntityTypeBuilder<NotificationModel> builder)
    {
        _ = builder.ToTable("notification");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("notification_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.UserId).HasColumnName("user_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.Date).HasColumnName("date").HasColumnType(ColumnTypes.Date);
        _ = builder.Property(a => a.Time).HasColumnName("time").HasColumnType(ColumnTypes.Time);
        _ = builder.Property(a => a.TemplateId).HasColumnName("template_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.Status).HasColumnName("status").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50).HasConversion(new BaseTypeStringConverter<NotificationStatus>());

        _ = builder.HasOne(a => a.User).WithMany().HasForeignKey(a => a.UserId);
        _ = builder.HasOne(a => a.Template).WithMany().HasForeignKey(a => a.TemplateId);
    }
}