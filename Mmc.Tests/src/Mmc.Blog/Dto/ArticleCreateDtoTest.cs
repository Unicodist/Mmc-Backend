using Mmc.Blog.Dto;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Dto;

public class ArticleCreateDtoTest
{
    private ArticleCreateDto _articleCreateDto;

    public ArticleCreateDtoTest()
    {
        _articleCreateDto = new ArticleCreateDto("title","body",2,3);
    }

    [Fact]
    public void Test__NewArticleCreateDtoTest_SetsAllNeccessaryProperties()
    {
        _articleCreateDto.Title = "xyz";
        _articleCreateDto.Body = "xyz";
        _articleCreateDto.AdminId = 1;
        _articleCreateDto.CategoryId = 1;
        Assert.Equal(1,_articleCreateDto.AdminId);
        Assert.Equal("xyz",_articleCreateDto.Title);
        Assert.Equal("xyz",_articleCreateDto.Body);
        Assert.Equal(1,_articleCreateDto.CategoryId);


    }
}