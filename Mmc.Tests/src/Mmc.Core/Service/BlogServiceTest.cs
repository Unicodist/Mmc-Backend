using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Core.Services.Blog;
using Moq;
using Xunit;

namespace Mmc.Tests.Mmc.Core.Service;

public class BlogServiceTest
{
   private readonly Mock<IArticleRepository> _articleRepository = new();
   private readonly Mock<IBlogUserRepository> _blogUserRepository = new();
   private readonly Mock<ICategoryRepository> _categoryRepository = new();
   private readonly BlogService _blogService;
   
   private readonly IArticle _article;
   private readonly ICategory _category;
   private readonly IBlogUser _blogUser;
   readonly DateOnly _someDate = new(2000,2,2);
   
   private readonly ArticleCreateDto _articleCreateDto;


   public BlogServiceTest()
   {
      _category = new Category("cat_name", "cat_desc");

      _blogUser = new BlogUser("Ashish", "AshuraNep", "abc.jpg");
      
      _article = new Article("title", "body", _someDate, _category, _blogUser,"xyz.jpg");

      _articleCreateDto = new ArticleCreateDto("title","body",3,"abc","abc.xyz");
      
      _articleRepository.Setup( a => a.GetByIdAsync(It.IsAny<long>())).Returns(Task.FromResult(_article)!);
      _blogUserRepository.Setup(a => a.GetBlogUserById(It.IsAny<long>())).Returns(Task.FromResult(_blogUser)!);
      _categoryRepository.Setup(a => a.GetByIdAsync(It.IsAny<long>())).Returns(Task.FromResult(_category)!);

      _blogService = new BlogService(_articleRepository.Object, _blogUserRepository.Object, _categoryRepository.Object);
   }

   [Fact]
   public async Task Test_CreateMethod_Creates_Blog_With_Provided_data()
   {
      await _blogService.Create(_articleCreateDto);
   }
}