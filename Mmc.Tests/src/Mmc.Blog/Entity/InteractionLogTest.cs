using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Entity;

public class InteractionLogTest
{
    private string _blogUserName = "Ashish";
    private string _blogUserUserName = "AshuraNep";

    private string _commentBody = "Hello Fren";
    
    private IPicture _picture;
    private IBlogUser _user;
    private IComment _comment;
    private IArticle _article;
    
    public InteractionLogTest()
    {
        _picture = new Picture("location.abc");
        _user = new BlogUser(_blogUserName, _blogUserUserName,_picture);
        _article = new Article(TestRepository.ArticleTitle,
            TestRepository.ArticleBody,
            TestRepository.Date,
            TestRepository.ArticleCategory,
            TestRepository.BlogUser,
            TestRepository.ArticleThumbnail);
        _comment = new Comment(_commentBody, _user, _article);
    }

    [Fact]
    public void Test_CommentCreateInteractionTest_Creates_Object_With_Correct_Value()
    {
        var obj = new InteractionLog(_comment,_user);
        Assert.Equal(0,obj.Id);
        Assert.Equal(new DateTime(),obj.DateTime);
        Assert.Equal(0,obj.UserId);
        Assert.Null(obj.OldValue);
        Assert.Null(obj.NewValue);
        Assert.Null(obj.ArticleId);
        Assert.Null(obj.CommentId);
        Assert.Null(obj.Article);
        Assert.Null(obj.Comment);
        
        
    }
}
