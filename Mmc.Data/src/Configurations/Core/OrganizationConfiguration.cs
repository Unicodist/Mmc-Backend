using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Core;

namespace Mmc.Data.Configurations.Core;

public class OrganizationConfiguration : IEntityTypeConfiguration<OrganizationModel>
{
    private static readonly OrganizationModel Organization = new(){Id = 1,Name = "Mechi Multiple Campus",Subtitle = "Bhadrapur", VdcId = 1, Ward = 5};
    public void Configure(EntityTypeBuilder<OrganizationModel> builder)
    {
        _ = builder.ToTable("organization");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("organization_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.VdcId).HasColumnName("vdc_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Name).HasColumnName("name").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Subtitle).HasColumnName("subtitle").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50);
        _ = builder.Property(a => a.Ward).HasColumnName("ward").HasColumnType(ColumnTypes.INT);

        _ = builder.HasOne(a => a.VdcModel).WithMany().HasForeignKey(a => a.VdcId);

        _ = builder.HasData(Organization);
    }
}
