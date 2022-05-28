using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Address;

namespace Mmc.Data.Configurations.Address;

public class StateConfiguration : IEntityTypeConfiguration<StateModel>
{
    public void Configure(EntityTypeBuilder<StateModel> builder)
    {
        _ = builder.ToTable("state");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("state_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.Name).HasColumnName("name").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50);
        _ = builder.Property(a => a.Description).HasColumnName("description").HasColumnType(ColumnTypes.Varchar).HasMaxLength(100);
        _ = builder.Property(a => a.CountryId).HasColumnName("country_id").HasColumnType(ColumnTypes.Bigint);

        _ = builder.HasOne(a => a.Country).WithMany(c => c.States).HasForeignKey(a => a.CountryId);
    }
}