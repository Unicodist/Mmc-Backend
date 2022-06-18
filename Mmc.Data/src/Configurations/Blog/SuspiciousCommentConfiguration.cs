using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Configurations.Blog;

public class SuspiciousCommentConfiguration : IEntityTypeConfiguration<SuspiciousCommentModel>
{
    public void Configure(EntityTypeBuilder<SuspiciousCommentModel> builder)
    {
        _ = builder.ToTable("suspicious_comment");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("suspicious_comment_id").HasColumnType(ColumnTypes.BIGINT);
    }
}