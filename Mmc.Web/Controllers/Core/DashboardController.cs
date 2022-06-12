using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmc.Blog.Repository;

namespace Mechi.Backend.Controllers.Core
{
    public class DashboardController : Controller
    {
        private readonly IArticleRepository _articleRepository;

        public DashboardController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            var blogCount = _articleRepository.GetQueryable().Count();
            return View();
        }
    }
}
