using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Blog.BaseType;
using Mmc.Blog.Enum;
using Mmc.Data.Model.Blog;
using Mmc.Data.TypeConverter.Blog;

namespace Mmc.Data.Configurations.Blog;

public class CommentConfiguration : IEntityTypeConfiguration<CommentModel>
{
    public void Configure(EntityTypeBuilder<CommentModel> builder)
    {
        _ = builder.ToTable("comment");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("comment_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Body).HasColumnName("body").HasColumnType(ColumnTypes.TEXT);
        _ = builder.Property(a => a.ArticleId).HasColumnName("article_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.UserId).HasColumnName("user_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.Status).HasColumnName("status").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).HasConversion(new BaseTypeStringConverter<Status>());
        _ = builder.Property(a => a.Guid).HasColumnName("guid").HasColumnType(ColumnTypes.VARCHAR).HasMaxLength(50).HasConversion(new BaseTypeStringConverter<GuidType>());

        _ = builder.HasOne(a => a.Article).WithMany().HasForeignKey(a => a.ArticleId);
        _ = builder.HasOne(a => a.User).WithMany().HasForeignKey(a => a.UserId);
    }
}