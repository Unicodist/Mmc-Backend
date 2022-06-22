using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class CommentTest
{
    private readonly Comment _comment;
    private readonly IBlogUser _bloguser;


    public CommentTest()
    {
        _comment = new Comment();
        _bloguser = null;
    }

    [Fact]
    public void Test_CommentTest_GetsAllNecessaryProperties()
    {
        Assert.Equal(0,_comment.Id);
        _comment.Body = "xyz";
        Assert.Equal("xyz",_comment.Body);
        Assert.Equal(0,_comment.UserId);
        Assert.Equal(0,_comment.ArticleId);
        _comment.Status=Status.Active;
        Assert.Equal(Status.Active,_comment.Status);
        Assert.Null(_comment.User);
        Assert.Null(_comment.Article);
        Assert.Null(_comment.Replies);
        Assert.Null(_comment.Guid);
        
        
        
        
    }

  /*  [Fact]
    
    public void Test_CommentWith_Parameter()
    {
        var _comment = new Comment(1, "xyz", Status.Active, User, "abcdd", "xyz", "abcd");


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