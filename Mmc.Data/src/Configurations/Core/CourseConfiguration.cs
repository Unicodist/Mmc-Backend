using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Core;

namespace Mmc.Data.Configurations.Core;

public class CourseConfiguration : IEntityTypeConfiguration<CourseModel>
{
    public void Configure(EntityTypeBuilder<CourseModel> builder)
    {
        _ = builder.ToTable("course");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("course_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.FacultyId).HasColumnName("faculty_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Name).HasColumnName("name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);;
        _ = builder.Property(a => a.Status).HasColumnName("status").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Guid).HasColumnName("guid").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);

        _ = builder.HasOne(a => a.Faculty).WithMany(a => a.Courses).HasForeignKey(a => a.FacultyId);
    }
}
