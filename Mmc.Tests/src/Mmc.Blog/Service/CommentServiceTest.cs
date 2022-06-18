using System.Reflection;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Enum;
using Mmc.Blog.Repository;
using Mmc.Blog.src.Service;
using Moq;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Service;

public class CommentServiceTest
{
    private Mock<ICommentRepository> _commentRepositoryMock = new();
    private CommentService _commentService;
    private IComment _comment;
    private readonly IComment _toxicComment;

    public CommentServiceTest()
    {
        _comment = new Comment();
        _toxicComment = new Comment()
        {
            Body = "This guy is an idiot. What a toad!",
            Status = Status.Active
        };
        typeof(Comment).GetProperty(nameof(Comment.Id))!.SetValue(_comment,1);
        _commentRepositoryMock.Setup(a => a.GetByIdAsync(It.IsAny<long>())).ReturnsAsync(_comment);
        
        _commentService = new CommentService(_commentRepositoryMock.Object);
    }

    [Fact]
    public void Test_CreatingCommentWithToxicKeywords_ThrowBadLanguageException()
    {
        _commentService.Create(_toxicComment);
    }
}