using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Address;

namespace Mmc.Data.Configurations.Address;

public class StateConfiguration : IEntityTypeConfiguration<StateModel>
{
    public static StateModel StateModel =
        new() {Name = "Province 1", Id = 1, CountryId = 1, Description = "Eastern most province"};
    public void Configure(EntityTypeBuilder<StateModel> builder)
    {
        _ = builder.ToTable("state");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("state_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Name).HasColumnName("name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Description).HasColumnName("description").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(100);
        _ = builder.Property(a => a.CountryId).HasColumnName("country_id").HasColumnType(ColumnTypes.BIGINT);

        _ = builder.HasOne(a => a.Country).WithMany(c => c.States).HasForeignKey(a => a.CountryId);

        _ = builder.HasData(StateModel);
    }
}
