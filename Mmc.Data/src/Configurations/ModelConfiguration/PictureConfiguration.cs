using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model;

namespace Mmc.Data.Configurations.ModelConfiguration;

public class PictureConfiguration : IEntityTypeConfiguration<PictureModel>
{
    private readonly ICollection<PictureModel> _initialPictures = new List<PictureModel>()
    {
        new("GodGuid", "Profile", "/Assets/Account/Profiles/SuperAdmin.jpg",DateTime.Now){Id=1},
        new("Avatar1", "Avatar", "/Assets/Account/Profiles/Avatar1.jpg",DateTime.Now){Id=2},
        new("Avatar2", "Avatar", "/Assets/Account/Profiles/Avatar2.jpg",DateTime.Now){Id=3},
        new("Avatar3", "Avatar", "/Assets/Account/Profiles/Avatar3.jpg",DateTime.Now){Id=4},
        new("Avatar4", "Avatar", "/Assets/Account/Profiles/Avatar4.jpg",DateTime.Now){Id=5},
        new("Avatar5", "Avatar", "/Assets/Account/Profiles/Avatar5.jpg",DateTime.Now){Id=6},
        new("Avatar6", "Avatar", "/Assets/Account/Profiles/Avatar6.jpg",DateTime.Now){Id=7},
        new("Avatar7", "Avatar", "/Assets/Account/Profiles/Avatar7.jpg",DateTime.Now){Id=8},
        new("Avatar8", "Avatar", "/Assets/Account/Profiles/Avatar8.jpg",DateTime.Now){Id=9},
        new("Avatar9", "Avatar", "/Assets/Account/Profiles/Avatar9.jpg",DateTime.Now){Id=10},
        new("Avatar10", "Avatar", "/Assets/Account/Profiles/Avatar10.jpg",DateTime.Now){Id=11},
        new("Avatar11", "Avatar", "/Assets/Account/Profiles/Avatar11.jpg",DateTime.Now){Id=12},
        new("Avatar12", "Avatar", "/Assets/Account/Profiles/Avatar12.jpg",DateTime.Now){Id=13},
        new("Avatar13", "Avatar", "/Assets/Account/Profiles/Avatar13.jpg",DateTime.Now){Id=14},
        new("Avatar14", "Avatar", "/Assets/Account/Profiles/Avatar14.jpg",DateTime.Now){Id=15},
        new("Avatar15", "Avatar", "/Assets/Account/Profiles/Avatar15.jpg",DateTime.Now){Id=16},
    };
    
    public void Configure(EntityTypeBuilder<PictureModel> builder)
    {
        _ = builder.ToTable("images");
        _ = builder.HasKey(a => a.Id); 
        _ = builder.Property(a => a.Id).HasColumnName("picture_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Guid).HasColumnName("guid").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Type).HasColumnName("type").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Location).HasColumnName("location").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(100);
        _ = builder.Property(a => a.UploadedDate).HasColumnName("uploaded_date").HasColumnType(ColumnTypes.DATETIME);
        _ = builder.HasData(_initialPictures);
    }
}
