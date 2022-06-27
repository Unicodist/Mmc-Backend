using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Core.BaseType;
using Mmc.Core.Enum;
using Mmc.Data.Model.Core;
using Mmc.Data.TypeConverter.Core;

namespace Mmc.Data.Configurations.Core;

public class StudentEnrollmentDetailConfiguration : IEntityTypeConfiguration<StudentEnrollmentModel>
{
    public void Configure(EntityTypeBuilder<StudentEnrollmentModel> builder)
    {
        _ = builder.ToTable("student_enrollment_detail");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("enrollment_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Guid).HasColumnName("guid").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(40).HasConversion(new BaseTypeStringConverter<GuidType>());
        _ = builder.Property(a => a.Semester).HasColumnName("semester").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(40).HasConversion(new EnumConverter<Semester>());
        _ = builder.Property(a => a.Status).HasColumnName("status").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(40).HasConversion(new EnumConverter<StudentEnrollmentStatus>());
        _ = builder.Property(a => a.UserId).HasColumnName("user_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.CourseId).HasColumnName("course_id").HasColumnType(ColumnTypes.BIGINT);

        _ = builder.HasOne(a => a.User).WithMany().HasForeignKey(a => a.UserId);
        _ = builder.HasOne(a => a.Course).WithMany().HasForeignKey(a => a.CourseId);
    }
}
