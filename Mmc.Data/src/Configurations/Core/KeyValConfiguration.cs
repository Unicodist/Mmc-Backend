using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Core.Entity;

namespace Mmc.Data.Configurations.Core;

public class KeyValConfiguration : IEntityTypeConfiguration<KeyVal>
{
    public void Configure(EntityTypeBuilder<KeyVal> builder)
    {
        _ = builder.HasKey(k=>k.Id);
        _ = builder.Property(k => k.Id).HasColumnName("id").HasColumnType(ColumnTypes.Bigint).HasMaxLength(50);
        _ = builder.Property(k => k.Key).HasColumnName("key").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50);
        _ = builder.Property(k => k.Value).HasColumnName("value").HasColumnType(ColumnTypes.Varchar).HasMaxLength(100);
        _ = builder.Property(k => k.Group).HasColumnName("group").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50);
        _ = builder.ToTable("keyValue");
    }
}