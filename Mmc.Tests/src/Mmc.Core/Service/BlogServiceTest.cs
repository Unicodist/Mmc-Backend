using Mmc.Blog.Dto;
using Mmc.Blog.Repository;
using Mmc.Core.Services.Blog;
using Xunit;

namespace Mmc.Tests.Mmc.Core.Service;

public class BlogServiceTest
{
   private readonly BlogService _blogService;
   private readonly IArticleRepository _articleRepository;
   private readonly IBlogUserRepository _blogUserRepository;
   private readonly ICategoryRepository _categoryRepository;

   
   public BlogServiceTest(IArticleRepository articleRepository, IBlogUserRepository blogUserRepository, ICategoryRepository categoryRepository)
   {
      _articleRepository = articleRepository;
      _blogUserRepository = blogUserRepository;
      _categoryRepository = categoryRepository;
   }

   [Fact]
   public async Task Test_CreateMethod_Creates_Blog_With_Provided_data()
   {
      var dto = new ArticleCreateDto();
      dto.Title = "xyz";
      dto.Body = "xyz";
      dto.AuthorName = "xyz";
      dto.CategoryId = 1;
      dto.PostedDate=DateTime.Now;
      await _blogService.Create(dto).ConfigureAwait(false);
     

   }
}