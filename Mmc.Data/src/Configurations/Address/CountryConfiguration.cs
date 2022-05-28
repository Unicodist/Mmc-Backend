using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Address;

namespace Mmc.Data.Configurations.Address;

public class CountryConfiguration : IEntityTypeConfiguration<CountryModel>
{
    public void Configure(EntityTypeBuilder<CountryModel> builder)
    {
        _ = builder.ToTable("country");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("country_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.Name).HasColumnName("name").HasColumnType(ColumnTypes.Varchar).HasMaxLength(100);
        _ = builder.Property(a => a.Description).HasColumnName("description").HasColumnType(ColumnTypes.Text);
        _ = builder.Property(a => a.Abr).HasColumnName("abr").HasColumnType(ColumnTypes.Varchar).HasMaxLength(10);
        _ = builder.Property(a => a.PhoneCode).HasColumnName("phone_code").HasColumnType(ColumnTypes.Varchar).HasMaxLength(40);

        _ = builder.HasMany(a => a.States).WithOne(s => s.Country).HasForeignKey(s => s.CountryId);
    }
}