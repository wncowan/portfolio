using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace csharp_portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
            {
                return View();
            }

        [HttpGet]
        [Route("/projects")]
        public IActionResult Projects()
            {
                return View();
            }

        [HttpGet]
        [Route("/contact")]
        public IActionResult Contact()
            {
                return View();
            }

        [HttpGet]
        [Route("/home")]
        public IActionResult Home()
        {
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        [Route("/submit")]
        public IActionResult submit()
        {
            return RedirectToAction("Index");
        }
    }
}