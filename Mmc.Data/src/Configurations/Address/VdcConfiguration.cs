using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Address;

namespace Mmc.Data.Configurations.Address
{
    internal class VdcConfiguration : IEntityTypeConfiguration<VdcModel>
    {
        public static VdcModel VdcModel =
            new() {Id = 1, Name = "Bhdrapur", Description = "Near Mechi River", StateId = 1};
        public void Configure(EntityTypeBuilder<VdcModel> builder)
        {
            _ = builder.ToTable("vdc");
            _ = builder.HasKey(a => a.Id);
            _ = builder.Property(a => a.Id).HasColumnName("vdc_id").HasColumnType(ColumnTypes.BIGINT);
            _ = builder.Property(a => a.Name).HasColumnName("name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
            _ = builder.Property(a => a.Description).HasColumnName("description").HasColumnType(ColumnTypes.TEXT);
            _ = builder.Property(a => a.StateId).HasColumnName("state_id").HasColumnType(ColumnTypes.BIGINT);

            _ = builder.HasOne(a => a.StateModel).WithMany(s => s.Vdcs).HasForeignKey(a => a.StateId);

            _ = builder.HasData(VdcModel);
        }
    }
}
