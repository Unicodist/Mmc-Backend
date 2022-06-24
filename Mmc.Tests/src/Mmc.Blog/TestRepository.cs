using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Blog.Service;
using Mmc.Blog.Service.Interface;
using Mmc.Blog.src.Service;
using Moq;

namespace Mmc.Tests.Mmc.Blog;

public static class TestRepository
{
    #region primitiveValues

    public const string ArticleTitle = "SomeTitle";
    public const string ArticleBody = "articleBody";
    public const string CategoryName = "categoryName";
    public const string CategoryDescription = "categoryName";
    public const string CommentBody = "commentBody";
    public const string UserName = "Ashish";
    public const string UserUserName = "AshuraNep";
    public const string PictureLocation = "/Assets/Picture/Wow.jpg";
    public const string ArticleThumbnail = "/Assets/Blog/Thumbnail/abcd.jpg";
    public static DateOnly Date = DateOnly.MaxValue;

    #endregion

    #region Mocks

    public static readonly Mock<ICommentRepository> CommentRepositoryMock = new();
    public static readonly Mock<IBlogUserRepository> BlogUserRepositoryMock = new();
    public static readonly Mock<IArticleRepository> ArticleRepositoryMock = new();
    public static readonly Mock<IInteractionLogRepository> InteractionLogRepositoryMock = new();

    #endregion

    #region Entities

    public static readonly ICategory? ArticleCategory = new Category(CategoryName, CategoryDescription);
    private static readonly IPicture Picture = new Picture(PictureLocation);
    public static readonly IBlogUser BlogUser = new BlogUser(UserName, UserUserName, Picture);
    public static readonly IArticle Article = new Article(ArticleTitle,ArticleBody,Date,ArticleCategory,BlogUser,ArticleThumbnail);
    public static readonly IComment Comment = new Comment(CommentBody,BlogUser,Article);
    public static readonly IInteractionLog InteractionLog = new InteractionLog(Article,BlogUser,Comment);


    #endregion

    #region Service

    public static ICommentService CommentService;
    public static IInteractionLogService IInteractionLogService;
    
    #endregion

    public static void Init()
    {
        typeof(Comment).GetProperty(nameof(Comment.Id))!.SetValue(Comment,1);

        CommentRepositoryMock.Setup(a => a.GetByIdAsync(It.IsAny<long>())).ReturnsAsync(Comment);
        ArticleRepositoryMock.Setup(a => a.GetByIdAsync(It.IsAny<long>())).ReturnsAsync(Article);
        BlogUserRepositoryMock.Setup(a => a.GetByIdAsync(It.IsAny<long>())).ReturnsAsync(BlogUser);
        InteractionLogRepositoryMock.Setup(a => a.GetByIdAsync(It.IsAny<long>())).ReturnsAsync(InteractionLog);

        IInteractionLogService =
            new InteractionLogService(InteractionLogRepositoryMock.Object, ArticleRepositoryMock.Object,CommentRepositoryMock.Object);
        CommentService = new CommentService(CommentRepositoryMock.Object, BlogUserRepositoryMock.Object,
            ArticleRepositoryMock.Object, IInteractionLogService);

    }
}
