using Mmc.Blog.Dto;
using Mmc.Blog.Entity;
using Mmc.Blog.Entity.Interface;
using Mmc.Blog.Repository;
using Mmc.Core.Services.Blog;
using Mmc.Data.Repository.Blog;
using Moq;
using Xunit;

namespace Mmc.Tests.Mmc.Core.Service;

public class BlogServiceTest
{
   private readonly BlogService _blogService;
   private readonly Mock<IArticleRepository> _articleRepository;
   private readonly IArticle _article;
   private ICategory _category;
   private IBlogUser _blogUser;
   private readonly IBlogUserRepository _blogUserRepository;
   private readonly ICategoryRepository _categoryRepository;
   private readonly ArticleCreateDto _articleCreateDto;
   DateTime _someDate = DateTime.Now;


   public BlogServiceTest()
   {
      _category = new Category("cat_name", "cat_desc");

      _blogUser = new BlogUser("Ashish", "AshuraNep", "abc.jpg");
      
      _article = new Article("title", "body", _someDate, _category, _blogUser);
      
      _articleCreateDto = new ArticleCreateDto("title","body",3,5);
      _articleRepository.Setup(a => a.GetByIdAsync(It.IsAny<long>())).Returns(_article);
      _blogUserRepository = blogUserRepository;
      _categoryRepository = categoryRepository;
   }

   [Fact]
   public async Task Test_CreateMethod_Creates_Blog_With_Provided_data()
   {
      dto.Title = "xyz";
      dto.Body = "xyz";
      dto.AuthorName = "xyz";
      dto.CategoryId = 1;
      dto.PostedDate=DateTime.Now;
      await _blogService.Create(dto).ConfigureAwait(false);
     

   }
}