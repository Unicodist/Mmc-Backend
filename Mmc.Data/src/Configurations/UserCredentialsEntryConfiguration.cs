using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.User.Entity;

namespace Mmc.Data.Configurations;

public class UserCredentialsEntryConfiguration : IEntityTypeConfiguration<UserCredentials>
{
    public void Configure(EntityTypeBuilder<UserCredentials> builder)
    {
        builder.ToTable("User_Credentials");
        builder.HasKey(u => u.UserCredentialsId);
        builder.Property(u => u.UserCredentialsId).HasColumnName("user_credentials_id");
        builder.Property(u => u.UserCredentialsEmail).HasColumnName("user_credentials_email").IsRequired();
        builder.Property(u => u.UserCredentialsPassword).HasColumnName("user_credentials_password").IsRequired();

        builder.HasOne(uc => uc.UserCredentialsUser).WithOne(u => u.UserMasterCredential);
    }
}