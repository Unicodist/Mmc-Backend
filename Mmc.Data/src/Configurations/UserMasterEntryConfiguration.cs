using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Configurations.TypeMapping;
using Mmc.User.Entity;

namespace Mmc.Data.Configurations;

public class UserMasterEntryConfiguration : IEntityTypeConfiguration<UserMasterEntity>
{
    public void Configure(EntityTypeBuilder<UserMasterEntity> builder)
    {
        builder.ToTable("User_Master");
        builder.HasKey(u => u.UserMasterId);
        builder.Property(u => u.UserMasterId).HasColumnType("bigint");
        builder.Property(u => u.UserMasterName).IsRequired();
        builder.Property(u => u.Email).IsRequired();
        builder.Property(u => u.Password).IsRequired();
        builder.Property(u => u.UserType).HasConversion(new UserTypeMapping());
    }
}