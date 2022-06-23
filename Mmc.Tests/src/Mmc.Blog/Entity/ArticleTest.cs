using Mmc.Blog.Entity;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class ArticleTest
{
    private readonly Article _article;
    private readonly BlogUser _blogUser;
    private readonly Category _category;
    private readonly Picture _picture;
    private readonly DateOnly _someDate = new(2000, 04, 03);

    public ArticleTest()
    {
        _blogUser = new BlogUser("Pramisa","Pramisa123",_picture);
        _category = new Category("cat","dog");
        _article = new Article("title","body",_someDate,_category,_blogUser,"xyz.jpg");
    }

    [Fact]
    public void Test_Creating_Article_Creates_Object_With_Correct_Values()
    {
       Assert.Equal(0,_article.Id);
       Assert.Equal("title",_article.Title);
        Assert.Equal("body",_article.Body);
        Assert.Equal(_someDate,_article.PostedDate);
        Assert.Equal(0,_article.CategoryId);
        Assert.Equal(_blogUser,_article.User);
        Assert.Equal("xyz.jpg",_article.Thumbnail);
        Assert.Equal("mmm",_article.Guid);
    }
    
    
}
