﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Address;

namespace Mmc.Data.Configurations.Address
{
    internal class VdcConfiguration : IEntityTypeConfiguration<VdcModel>
    {
        public void Configure(EntityTypeBuilder<VdcModel> builder)
        {
            _ = builder.ToTable("vdc");
            _ = builder.HasKey(a => a.Id);
            _ = builder.Property(a => a.Id).HasColumnName("vdc_id").HasColumnType(ColumnTypes.BIGINT);
            _ = builder.Property(a => a.Name).HasColumnName("name").HasColumnType(ColumnTypes.BIGINT);
            _ = builder.Property(a => a.Description).HasColumnName("description").HasColumnType(ColumnTypes.BIGINT);
            _ = builder.Property(a => a.StateId).HasColumnName("state_id").HasColumnType(ColumnTypes.BIGINT);

            _ = builder.HasOne(a => a.State).WithMany(s => s.Vdcs).HasForeignKey(a => a.StateId);
        }
    }
}
