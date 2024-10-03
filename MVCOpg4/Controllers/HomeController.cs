using Microsoft.AspNetCore.Mvc;
using MVCOpg4.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;   

namespace MVCOpg4.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
        }

        public IActionResult Index()
        {
            return View();
        }

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
