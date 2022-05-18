using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.User;
using Mmc.Data.TypeConverter;
using Mmc.User.Enum;

namespace Mmc.Data.Configurations;

public class UserMasterEntryConfiguration : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        builder.ToTable("user");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("bigint");
        builder.Property(u => u.Name).HasColumnName("name").IsRequired();
        builder.Property(u => u.Email).HasColumnName("email").IsRequired();
        builder.Property(u => u.Password).HasColumnName("password").IsRequired();
        builder.Property(u => u.UserType).HasColumnName("user_type").HasConversion(new BaseTypeStringConverter<UserType>());
    }
}