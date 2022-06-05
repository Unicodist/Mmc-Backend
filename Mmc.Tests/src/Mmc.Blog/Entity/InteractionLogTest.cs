using Mmc.Blog.Entity;
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
        Assert.Null(obj.OldValue);
        Assert.Null(obj.NewValue);
        Assert.Null(obj.ArticleId);
        Assert.Null(obj.CommentId);
        Assert.Null(obj.Article);
        Assert.Null(obj.Comment);
        
        
    }
}