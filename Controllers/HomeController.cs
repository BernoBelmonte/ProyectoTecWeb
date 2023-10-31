using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
//hola
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bikes()
        {
            return View();
        }

        public IActionResult Equipment()
        {
            return View();
        }
        
        public IActionResult Tools()
        {
            return View();
        }

        public IActionResult Workshop() 
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