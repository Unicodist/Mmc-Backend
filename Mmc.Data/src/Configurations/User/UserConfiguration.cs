using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.User;
using Mmc.Data.TypeConverter;
using Mmc.User.Enum;

namespace Mmc.Data.Configurations.User;

public class UserConfiguration : IEntityTypeConfiguration<BlogNoticeUserModel>
{
    public void Configure(EntityTypeBuilder<BlogNoticeUserModel> builder)
    {
        builder.ToTable("user");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnName("user_id").HasColumnType("bigint");
        builder.Property(u => u.Name).HasColumnName("name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).IsRequired();
        builder.Property(u => u.Email).HasColumnName("email").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).IsRequired();
        builder.Property(u => u.Password).HasColumnName("password").HasColumnType(ColumnTypes.TEXT).IsRequired();
        builder.Property(u => u.UserType).HasColumnName("user_type").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        builder.Property(u => u.UserName).HasColumnName("user_name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).IsRequired();

        builder.HasData(new BlogNoticeUserModel(){
            Id = 1,
            Name = "Ashish Neupane",
            Email = "ashishneupane999@gmail.com",
            Password = BCrypt.Net.BCrypt.HashPassword("jotkoproject"),
            UserType = "Superuser",
            UserName = "AshuraNep"
        });
    }
}