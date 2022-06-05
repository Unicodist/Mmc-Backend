using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class ArticleTest
{
    private readonly Article _article;
    private readonly BlogUser _blogUser;
    private readonly Category _category;
    [Fact]
    public void New__ArticleTest_SetsAllNecessaryProperties()
    {
        var obj = new Article();
       Assert.Equal(0,obj.Id);
       Assert.Equal(null,obj.Title);
        Assert.Equal(null,obj.Body);
        Assert.Equal(new DateTime(),obj.PostedDate);
        Assert.Equal(null,obj.AuthorName);
        Assert.Equal(0,obj.CategoryId);
        Assert.Equal(0,obj.AdminId);
      





    }
    
    
}