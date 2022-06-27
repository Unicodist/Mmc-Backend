using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Blog.Enum;
using Mmc.Data.Model.Blog;
using Mmc.Data.TypeConverter.Blog;

namespace Mmc.Data.Configurations.Blog;

public class ToxicCommentConfiguration : IEntityTypeConfiguration<ToxicCommentModel>
{
    public void Configure(EntityTypeBuilder<ToxicCommentModel> builder)
    {
        _ = builder.ToTable("toxic_comment");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("toxic_comment_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.CommentId).HasColumnName("comment_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Status).HasColumnName("status").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(40).HasConversion(new EnumConverter<ToxicCommentStatus>());

        _ = builder.HasOne(a => a.Comment).WithMany().HasForeignKey(a => a.CommentId);
    }
}
