using System.ComponentModel.Design;
using Mmc.Blog.Entity;
using Mmc.Blog.Enum;
using Xunit;



namespace Mmc.Tests.Mmc.Blog.Entity;

public class CategoryTest
{
    [Fact]
    public void Test__CategoryTest_GetsAllNecessaryProperties()
    {
        var obj = new Category();
        Assert.Equal(0, obj.Id);
        Assert.Equal(null,obj.Description);
        Assert.Equal(null,obj.Name);
        Assert.Equal(null,obj.Status);
        Assert.Equal(null,obj.BlogPosts);
    }
}