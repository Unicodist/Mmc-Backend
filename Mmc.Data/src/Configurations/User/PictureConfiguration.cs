using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model;

namespace Mmc.Data.Configurations.User;

public class PictureConfiguration : IEntityTypeConfiguration<PictureModel>
{
    private static readonly PictureModel SuperAdmin = new("GodGuid", "Avatar", "/Assets/Account/Profiles/SuperAdmin.jpg",DateTime.Now){Id=1};
    public void Configure(EntityTypeBuilder<PictureModel> builder)
    {
        _ = builder.ToTable("user_picture");
        _ = builder.HasKey(a => a.Id); 
        _ = builder.Property(a => a.Id).HasColumnName("picture_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Guid).HasColumnName("guid").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Type).HasColumnName("type").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Location).HasColumnName("location").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(100);
        _ = builder.Property(a => a.UploadedDate).HasColumnName("uploaded_date").HasColumnType(ColumnTypes.DATETIME);

        _ = builder.HasData(SuperAdmin);
    }
}
