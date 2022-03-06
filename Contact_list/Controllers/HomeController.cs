using Contact_list.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Contact_list.Domain.Entities;

namespace Contact_list.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        //[HttpPost]
        //public IActionResult Create(Contact cont)
        //{

        //}
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