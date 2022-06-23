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
        builder.Property(u => u.Name).HasColumnName("name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).IsRequired();
        builder.Property(u => u.Email).HasColumnName("email").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).IsRequired();
        builder.Property(u => u.Password).HasColumnName("password").HasColumnType(ColumnTypes.TEXT).IsRequired();
        builder.Property(u => u.UserType).HasColumnName("user_type").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        builder.Property(u => u.UserName).HasColumnName("user_name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).IsRequired();
        builder.Property(u => u.PictureId).HasColumnName("picture_id").HasColumnType(ColumnTypes.BIGINT).HasMaxLength(50);

        _ = builder.HasOne(a => a.Picture).WithMany().HasForeignKey(a => a.PictureId);

        builder.HasData(new UserModel
        {
            Id = 1,
            Name = "Ashish Neupane",
            Email = "ashishneupane999@gmail.com",
            Password = BCrypt.Net.BCrypt.HashPassword("ShineBright"),
            UserType = "Superuser",
            UserName = "AshuraNep",
            PictureId = 1
        });
    }
}
