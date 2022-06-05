using System.ComponentModel.Design;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;
using Xunit;



namespace Mmc.Tests.Mmc.Blog.Entity;

public class CategoryTest
{
    private Category cat = new Category("cat", "dog");
    [Fact]
    public void Test_catTest_GetsAllNecessaryProperties()
    {
        Assert.Equal(0, cat.Id);
        Assert.Equal("dog",cat.Description);
        Assert.Equal("cat",cat.Name);
        Assert.Equal(Status.Active,cat.Status);
        Assert.Equal(new List<IArticle>(),cat.BlogPosts);
    }
}