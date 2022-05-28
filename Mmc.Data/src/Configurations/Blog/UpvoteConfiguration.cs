using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mmc.Data.Model.Blog;

namespace Mmc.Data.Configurations.Blog;

public class UpvoteConfiguration : IEntityTypeConfiguration<UpvoteModel>
{
    public void Configure(EntityTypeBuilder<UpvoteModel> builder)
    {
        _ = builder.ToTable("upvote");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("upvoteId").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.ArticleId).HasColumnName("blog_id").HasColumnType(ColumnTypes.Bigint);
        _ = builder.Property(a => a.UserId).HasColumnName("user_id").HasColumnType(ColumnTypes.Bigint);

        _ = builder.HasOne(a => a.Article).WithMany().HasForeignKey(a => a.ArticleId);
        _ = builder.HasOne(a => a.User).WithMany().HasForeignKey(a => a.UserId);
    }
}