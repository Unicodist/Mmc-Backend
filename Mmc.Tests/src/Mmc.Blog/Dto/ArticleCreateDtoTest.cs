using Mmc.Blog.Dto;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Dto;

public class ArticleCreateDtoTest
{
    private ArticleCreateDto _articleCreateDto;

    public ArticleCreateDtoTest()
    {
        _articleCreateDto = new ArticleCreateDto("title","body",2,"abc","abc.xyz");
    }

    [Fact]
    public void Test__NewArticleCreateDtoTest_SetsAllNeccessaryProperties()
    {
        Assert.Equal(2,_articleCreateDto.AdminId);
        Assert.Equal("title",_articleCreateDto.Title);
        Assert.Equal("body",_articleCreateDto.Body);
        Assert.Equal("abc",_articleCreateDto.CategoryGuid);


    }
}