using Mmc.Blog.Dto;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Dto;

public class ArticleCreateDtoTest
{
    [Fact]
    public void Test__NewArticleCreateDtoTest_SetsAllNeccessaryProperties()
    {
        var obj = new ArticleCreateDto();
        obj.Title = "xyz";
        obj.Body = "xyz";
        obj.AdminId = 1;
        obj.AuthorName = "pramisa";
        obj.CategoryId = 1;
        obj.PostedDate = DateTime.Now;
        Assert.Equal(1,obj.AdminId);
        Assert.Equal("xyz",obj.Title);
        Assert.Equal("xyz",obj.Body);
        Assert.Equal("pramisa" ,obj.AuthorName);
        Assert.Equal(1,obj.CategoryId);
        Assert.Equal(DateTime.Now, obj.PostedDate);


    }
}