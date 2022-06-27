using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Configurations.Blog;

public class UpvoteConfiguration : IEntityTypeConfiguration<HeartModel>
{
    public void Configure(EntityTypeBuilder<HeartModel> builder)
    {
        _ = builder.ToTable("upvote");
        _ = builder.HasKey(a => new{a.ArticleId,a.UserId});
        _ = builder.Property(a => a.ArticleId).HasColumnName("blog_id").HasColumnType(ColumnTypes.BIGINT);
        _ = builder.Property(a => a.UserId).HasColumnName("user_id").HasColumnType(ColumnTypes.BIGINT);

        _ = builder.HasOne(a => a.Article).WithMany(a=>a.Likes).HasForeignKey(a => a.ArticleId);
        _ = builder.HasOne(a => a.User).WithMany().HasForeignKey(a => a.UserId);
    }
}
