using Mmc.Blog.Entity;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class BlogUserTest
{
    private BlogUser _blogUser;
    private Picture _picture;

    public BlogUserTest()
    {
        _blogUser = new BlogUser("Pramisa","Pramisa123",_picture);
    }

    [Fact]
    public void New__BlogUserTest_SetsAllNecessaryProperties()
    {
        Assert.Equal(0,_blogUser.Id);
        Assert.Equal("Pramisa",_blogUser.Name);
        Assert.Equal("Pramisa123",_blogUser.UserName);
        Assert.Null(_blogUser.Pictures);
        

    }
    

}
