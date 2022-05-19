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
        _ = builder.Property(a => a.Id).HasColumnName("country_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Name).HasColumnName("country_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Description).HasColumnName("country_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Abr).HasColumnName("country_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.PhoneCode).HasColumnName("country_id").HasColumnType(ColumnTypes.BIGINT);

        _ = builder.HasMany(a => a.States).WithOne(s => s.Country).HasForeignKey(s => s.CountryId);
    }
}