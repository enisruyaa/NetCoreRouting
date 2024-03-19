using Microsoft.AspNetCore.Mvc;
using NetCoreRouting_0Tekrar.Models;
using System.Diagnostics;

namespace NetCoreRouting_0Tekrar.Controllers
{
    //Attribute Based Routing
    [Route("simRoute")] // Ýçerdeki yer tutuculara dikkat ediniz. Unutmayýn ki Attribute Based Routing eðer Middleware'deki defult'ta bir Conrroller'a denk geliyorsa o sistemi ezer..
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("/a/Deneme")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("DDD")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
