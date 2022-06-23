using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Configurations.Blog;

public class LikeConfiguration : IEntityTypeConfiguration<LikeModel>
{
    public void Configure(EntityTypeBuilder<LikeModel> builder)
    {
        _ = builder.ToTable("like");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("like_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.UserId).HasColumnName("user_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.ArticleId).HasColumnName("article_id").HasColumnType(ColumnTypes.BIGINT);

        _ = builder.HasOne(a => a.Article).WithMany(a => a.Likes).HasForeignKey(a => a.ArticleId);
        _ = builder.HasOne(a => a.User).WithMany().HasForeignKey(a => a.UserId);
    }
}
