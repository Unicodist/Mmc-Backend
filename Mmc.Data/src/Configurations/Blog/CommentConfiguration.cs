using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
        _ = builder.Property(a => a.Id).HasColumnName("comment_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.Body).HasColumnName("body").HasColumnType(ColumnTypes.Text);
        _ = builder.Property(a => a.ArticleId).HasColumnName("article_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.ParentId).HasColumnName("parent_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.UserId).HasColumnName("user_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.Status).HasColumnName("status").HasColumnType(ColumnTypes.Varchar).HasMaxLength(50).HasConversion(new BaseTypeStringConverter<Status>());

        _ = builder.HasOne(a => a.Article).WithMany().HasForeignKey(a => a.ArticleId);
        _ = builder.HasOne(a => a.User).WithMany().HasForeignKey(a => a.UserId);
        _ = builder.HasOne(a => a.Parent).WithMany(a=>a.Replies).HasForeignKey(a => a.ParentId);
    }
}