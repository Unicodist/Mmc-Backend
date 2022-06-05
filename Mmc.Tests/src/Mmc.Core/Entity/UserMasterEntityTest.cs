using Mmc.Core.Entity;
using Xunit;

namespace Mmc.Tests.Mmc.Core.Entity;

public class UserMasterEntityTest
{
    [Fact]
    public void Test_UserMasterEntityTest()
    {
        var obj = new KeyVal();
        obj.Key = "xyz";
        obj.Value = "abcd";
        Assert.Equal("xyz",obj.Key);
        Assert.Equal("abcd",obj.Value);
    }

    [Fact]
    public void Test_SetValue()
    {
        var obj = new KeyVal();
        obj.SetValue("xyz");
     
    }
    
}