using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.ViewModel;
using Mmc.Data.Repository;

namespace Mmc.Backend.Controllers
{
    public class ReadController : Controller
    {
        private readonly BlogPostRepository _blogPostRepository;

        public ReadController(BlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }
        public async Task<IActionResult> Index(long id=1)
        {
            var post = await _blogPostRepository.GetById(id);
            var dto = new ReadModel
            {
                Title = post.BlogMasterTitle,
                Body = post.BlogMasterBody,
                Author = post.BlogMasterAuthorName,
                PostedOn = post.BlogMasterPostedDate,
                viewCount = 123,
                Tags = new List<string>()
            };
            ViewData["blogInfo"] = dto;
            return View();
        }
    }
}
