using Mmc.Blog.BaseType;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.BaseType;

public class GuidTypeTest
{
    [Fact]

    public void Test_ToStringMethod_ReturnsGivenValueInStringFormat()
    {
        GuidType guidType = new ("xyz");
        Assert.IsType<string>(guidType.ToString());

    }

    [Fact]
    public void Test_GuidType()
    {
        GuidType name = new GuidType("abc");
        string name2 = name.ToString();
        Assert.Equal("abc",name2);
    }
  
     
}