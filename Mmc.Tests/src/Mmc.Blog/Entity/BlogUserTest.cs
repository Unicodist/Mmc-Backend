using Mmc.Blog.Entity;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class BlogUserTest
{
    [Fact]
    public void New__BlogUserTest_SetsAllNecessaryProperties()
    {
        var obj = new BlogUser();
        Assert.Equal(0,obj.Id);
        Assert.Equal(null,obj.Name);
        Assert.Equal(null,obj.UserName);
        Assert.Equal(null,obj.picture);
        

    }
    

}