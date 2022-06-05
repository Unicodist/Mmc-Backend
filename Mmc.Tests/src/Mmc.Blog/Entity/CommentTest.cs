using Mmc.Blog.BaseType;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class CommentTest
{
    private readonly Comment _comment;
    private readonly IBlogUser _bloguser;
    
    
    [Fact]
    public void Test_CommentTest_GetsAllNecessaryProperties()
    {
        var obj = new Comment();
        Assert.Equal(0,obj.Id);
        obj.Body = "xyz";
        Assert.Equal("xyz",obj.Body);
        Assert.Equal(0,obj.UserId);
        Assert.Equal(0,obj.ArticleId);
        Assert.Equal(0,obj.ParentId);
        obj.Status=Status.Active;
        Assert.Equal(Status.Active,obj.Status);
        Assert.Equal(null,obj.Parent);
        Assert.Equal(null,obj.User);
        Assert.Equal(null,obj.Article);
        Assert.Equal(null,obj.Replies);
        Assert.Equal(null,obj.Guid);
        
        
        
        
    }

  /*  [Fact]
    
    public void Test_CommentWith_Parameter()
    {
        var obj = new Comment(1, "xyz", Status.Active, User, "abcdd", "xyz", "abcd");


    }*/
   [Fact]
   public void Test_UpdateMethod_UpdateComment()
   {
       var _comment = new Comment();
       const string body = "test";
       _comment.Update(body);
       Assert.Equal(body,_comment.Body);
   }
}