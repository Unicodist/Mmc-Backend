using Mmc.Blog.Entity;
using NuGet.ContentModel;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class InteractionLogTest
{

    [Fact]
    public void Test_InteractionTest()
    {
        var obj = new InteractionLog();
        Assert.Equal(0,obj.Id);
        Assert.Equal(new DateTime(),obj.DateTime);
        Assert.Equal(0,obj.UserId);
        Assert.Equal(null,obj.OldValue);
        Assert.Equal(null,obj.NewValue);
        Assert.Equal(null,obj.ArticleId);
        Assert.Equal(null,obj.CommentId);
        Assert.Equal(null,obj.Article);
        Assert.Equal(null,obj.Comment);
        
        
    }
}