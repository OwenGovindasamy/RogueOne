using Microsoft.AspNetCore.Mvc;
using RogueOne.Interfaces;
using RogueOne.Logic;
using RogueOne.Models;
using RogueOne.ViewModels;
using System.Diagnostics;

namespace RogueOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IInstagramLooter _instagramLooter;

        public HomeController(ILogger<HomeController> logger, IInstagramLooter instagramLooter)
        {
            _logger = logger;
            _instagramLooter = instagramLooter;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<UserDescription> GetUserId(string username)
        {
            UserDescription userDetails = await _instagramLooter.GetUserId(username);

            return (userDetails);
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
