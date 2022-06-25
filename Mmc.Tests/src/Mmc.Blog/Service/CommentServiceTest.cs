using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Service.Interface;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Service;

public class CommentServiceTest
{
    private readonly ICommentService _commentService;
    private IComment _comment;

    public CommentServiceTest()
    {
        TestRepository.Init();
        
        _comment = TestRepository.Comment;
        _commentService  = TestRepository.CommentService;
    }
    [Fact]
    public void Test_CreatingComment_ChangesStatusToPending()
    {
    }
}
