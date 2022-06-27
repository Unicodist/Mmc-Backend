using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Core;

namespace Mmc.Data.Configurations.Core;

public class OrganizationConfiguration : IEntityTypeConfiguration<OrganizationModel>
{
    public void Configure(EntityTypeBuilder<OrganizationModel> builder)
    {
        _ = builder.ToTable("organization");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("organization_id").HasColumnType(ColumnTypes.BIGINT);
    }
}
