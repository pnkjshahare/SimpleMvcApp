using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleMvcApp.Models;

namespace SimpleMvcApp.Controllers
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

            // dotnet sonarscanner begin /k:"SimpleMvcApp" /d:sonar.host.url="http://localhost:9000"  /d:sonar.token="sqp_dd5ccedd458c041105f64fc264fe323d667cce3d"
            //  dotnet build
            //  dotnet sonarscanner end /d:sonar.token="sqp_dd5ccedd458c041105f64fc264fe323d667cce3d"

            string s = "pankaaa";
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
