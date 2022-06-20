using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Notice;
using Mmc.Data.TypeConverter.Notice;
using Mmc.Notice.BaseType;
using Mmc.Notice.Enum;

namespace Mmc.Data.Configurations.Notice;
public class NoticeConfiguration : IEntityTypeConfiguration<NoticeModel>
{
    public void Configure(EntityTypeBuilder<NoticeModel> builder)
    {
        _ = builder.ToTable("notice");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("notice_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.AdminId).HasColumnName("admin_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Body).HasColumnName("body").HasColumnType(ColumnTypes.TEXT);
        _ = builder.Property(a => a.Guid).HasColumnName("guid").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(40).HasConversion(new BaseTypeStringConverter<GuidType>());
        _ = builder.Property(a => a.Status).HasColumnName("status").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(40).HasConversion(new EnumConverter<Status>());
        _ = builder.Property(a => a.Picture).HasColumnName("picture").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(100);
        _ = builder.Property(a => a.Title).HasColumnName("title").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.PostedOn).HasColumnName("date").HasColumnType(ColumnTypes.DATETIME);

        _ = builder.HasOne(n => n.Author)
            .WithMany()
            .HasForeignKey(n=>n.AdminId);
    }
}