using Mmc.Blog.BaseType;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class ArticleTest
{
    private readonly Article _article;
    private readonly BlogUser _blogUser;
    private readonly Category _category;
    private DateTime someDate = new DateTime(2000, 04, 03);

    public ArticleTest()
    {
        _blogUser = new BlogUser("Pramisa","Pramisa123","xyz.png");
        _category = new Category("cat","dog");
        _article = new Article("title","body",someDate,_category,_blogUser,"xyz.jpg",new GuidType("mmm"));
    }

    [Fact]
    public void Test_Creating_Article_Creates_Object_With_Correct_Values()
    {
       Assert.Equal(0,_article.Id);
       Assert.Equal("title",_article.Title);
        Assert.Equal("body",_article.Body);
        Assert.Equal(someDate,_article.PostedDate);
        Assert.Equal(0,_article.CategoryId);
        Assert.Equal(_blogUser,_article.AuthorAdmin);
        Assert.Equal("xyz.jpg",_article.Thumbnail);
        Assert.Equal("mmm",_article.Guid);
    }
    
    
}