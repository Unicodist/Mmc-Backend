using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Core.Entity;

namespace Mmc.Data.Configurations;

public class UserCredentialsEntryConfiguration : IEntityTypeConfiguration<UserCredentials>
{
    public void Configure(EntityTypeBuilder<UserCredentials> builder)
    {
        builder.ToTable("User_Credentials");
        builder.HasKey(u => u.UserCredentialsId);
        builder.Property(u => u.UserCredentialsId).HasColumnType("INT(11)");
        builder.Property(u => u.UserCredentialsEmail).HasColumnType("TEXT").IsRequired();
        builder.Property(u => u.UserCredentialsPassword).HasColumnType("TEXT").IsRequired();
    }
}