using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class CommentTest
{
    private readonly IComment _comment;
    private readonly IBlogUser _bloguser;


    public CommentTest()
    {
        _comment = TestRepository.Comment;
        _bloguser = null;
    }

    [Fact]
    public void Test_CommentTest_GetsAllNecessaryProperties()
    {
        Assert.Equal(1,_comment.Id);
        Assert.Equal(TestRepository.CommentBody,_comment.Body);
        Assert.Equal(0,_comment.UserId);
        Assert.Equal(0,_comment.ArticleId);
        Assert.Equal(Status.Active,_comment.Status);
        Assert.Equal(TestRepository.BlogUser,_comment.User);
        Assert.Equal(TestRepository.Article,_comment.Article);
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
