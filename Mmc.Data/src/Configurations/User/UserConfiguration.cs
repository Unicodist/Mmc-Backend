using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.User;

namespace Mmc.Data.Configurations.User;

public class UserConfiguration : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        builder.ToTable("user");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnName("user_id").HasColumnType("bigint");
        builder.Property(u => u.Name).HasColumnName("name").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50).IsRequired();
        builder.Property(u => u.Email).HasColumnName("email").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50).IsRequired();
        builder.Property(u => u.Password).HasColumnName("password").HasColumnType(ColumnTypes.Text).IsRequired();
        builder.Property(u => u.UserType).HasColumnName("user_type").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50);
        builder.Property(u => u.UserName).HasColumnName("user_name").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50).IsRequired();

        builder.HasData(new UserModel(){
            Id = 1,
            Name = "Ashish Neupane",
            Email = "ashishneupane999@gmail.com",
            Password = BCrypt.Net.BCrypt.HashPassword("ShineBright"),
            UserType = "Superuser",
            UserName = "AshuraNep"
        });
    }
}