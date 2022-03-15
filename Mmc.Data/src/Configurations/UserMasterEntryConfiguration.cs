using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.User.Entity;

namespace Mmc.Data.Configurations;

public class UserMasterEntryConfiguration : IEntityTypeConfiguration<UserMaster>
{
    public void Configure(EntityTypeBuilder<UserMaster> builder)
    {
        builder.ToTable("User_Master");
        builder.HasKey(u => u.UserMasterId);
        builder.Property(u => u.UserMasterId).HasColumnName("user_id");
        builder.Property(u => u.UserMasterName).HasColumnName("user_name");
        builder.Property(u => u.UserMasterCredentialId).HasColumnName("user_credentials");

        builder.HasOne(u => u.UserMasterCredential).WithOne(uc => uc.UserCredentialsUser).HasForeignKey<UserCredentials>(uc=>uc.UserCredentialsUserId);
        builder.HasMany(u => u.Blogs).WithOne(b => b.BlogMasterAuthorAdmin).HasForeignKey(a => a.BlogMasterId);
    }
}