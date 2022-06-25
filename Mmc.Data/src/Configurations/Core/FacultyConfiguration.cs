using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Core;

namespace Mmc.Data.Configurations.Core;

public class FacultyConfiguration : IEntityTypeConfiguration<FacultyModel>
{
    public void Configure(EntityTypeBuilder<FacultyModel> builder)
    {
        _ = builder.ToTable("faculty");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("faculty_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Name).HasColumnName("name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Guid).HasColumnName("guid").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        
        _ = builder.HasMany(a => a.Courses).WithOne(a => a.Faculty).HasForeignKey(a => a.FacultyId);
    }
}
