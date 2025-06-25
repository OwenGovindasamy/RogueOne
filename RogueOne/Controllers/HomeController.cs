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
            UserDescription userDescription = await _instagramLooter.GetUserId(username);

            return userDescription;
        }
        public async Task<UserDetails> GetUserDetailsFromUserId(string userId)
        {
            UserDetails userDetails = await _instagramLooter.GetUserDetailsFromUserId(userId);

            return userDetails;
        }
        public async Task<MetaList> GetMetaListFromUserId(string userId)
        {
            MetaList metaList = await _instagramLooter.GetMetaListFromUserId(userId);

            return metaList;
        }
        public async Task<ReelListDetails> GetReelsFromUserId(string userId)
        {
            ReelListDetails list = await _instagramLooter.GetReelsFromUserId(userId);

            return list;
        }
    }
}
