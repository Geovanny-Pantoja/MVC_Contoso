using Microsoft.AspNetCore.Mvc;
using MVC_Contoso.Models;
using System.Diagnostics;

namespace MVC_Contoso.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sessions()
        {
            List<Session> sessionsList = new();
            Session sessionOne = new Session(1, "Linux", "Anu");
            Session sessionTwo = new Session(2, "Windows", "Alex");
            Session sessionThree = new Session(3, "Mac", "Trevon");

            sessionsList.Add(sessionOne);
            sessionsList.Add(sessionTwo);
            sessionsList.Add(sessionThree);

            Sessions sessions = new Sessions()
            {
                sessionsList = sessionsList
            };

            return View(sessions);
        }


        public IActionResult SessionDetails()
        {
            Sessions sessionOne = new Sessions(1, "Linux", "Anu");

            return View(sessionOne);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}