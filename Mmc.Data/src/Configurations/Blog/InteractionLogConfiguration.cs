using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Blog.Enum;
using Mmc.Data.Model.Blog;
using Mmc.Data.TypeConverter.Blog;

namespace Mmc.Data.Configurations.Blog;

public class InteractionLogConfiguration : IEntityTypeConfiguration<InteractionLogModel>
{
    public void Configure(EntityTypeBuilder<InteractionLogModel> builder)
    {
        _ = builder.ToTable("interaction_log");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("log_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.InteractionType).HasColumnName("type").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).HasConversion(new EnumConverter<InteractionType>());
        _ = builder.Property(a => a.ArticleId).HasColumnName("article_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.CommentId).HasColumnName("comment_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.DateTime).HasColumnName("date").HasColumnType(ColumnTypes.DATETIME);
        _ = builder.Property(a => a.NewValue).HasColumnName("new_value").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(100);
        _ = builder.Property(a => a.OldValue).HasColumnName("old_value").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(100);
        _ = builder.Property(a => a.UserId).HasColumnName("user_id").HasColumnType(ColumnTypes.BIGINT);

        _ = builder.HasOne(a => a.Comment).WithMany().HasForeignKey(a => a.CommentId);
        _ = builder.HasOne(a => a.Article).WithMany(a=>a.Interactions).HasForeignKey(a => a.ArticleId);
    }
}
