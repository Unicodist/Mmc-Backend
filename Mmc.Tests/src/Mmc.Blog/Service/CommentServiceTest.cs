using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Blog.src.Service;
using Moq;
using Xunit;

namespace Mmc.Tests.Mmc.Blog.Service;

public class CommentServiceTest
{
    private readonly Mock<ICommentRepository> _commentRepositoryMock = new();
    private readonly Mock<IBlogUserRepository> _blogUserRepository = new();
    private readonly Mock<IArticleRepository> _articleRepositoryMock = new();
    private readonly CommentService _commentService;
    private IComment _comment;
    private readonly CommentCreateDto _toxicComment;

    public CommentServiceTest()
    {
        _comment = new Comment();
        _toxicComment = new("someGuid", "This sounds so stupid what the hell", 1);
        typeof(Comment).GetProperty(nameof(Comment.Id))!.SetValue(_comment,1);
        _commentRepositoryMock.Setup(a => a.GetByIdAsync(It.IsAny<long>())).ReturnsAsync(_comment);
        
        _commentService = new CommentService(_commentRepositoryMock.Object,_blogUserRepository.Object,_articleRepositoryMock.Object);
    }
    [Fact]
    public void Test_CreatingComment_ChangesStatusToPending()
    {
        _commentService.Create(_toxicComment);
    }
}