using AllAboutWillWood.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System;

namespace AllAboutWillWood.Controllers
{
    public class HomeController : Controller
    {
        private static List<StoryPost> CurrentStories = new List<StoryPost>
        {
            new StoryPost
            {
                Title = "When I started listening to Will Wood",
                Topic = "Becoming a fan",
                StoryYear = 2023,
                Text = "I started listening to Will Wood shortly after the release of his most recent album, back in february. The song that got me into him was Misanthropologist",
                Name = "Admin",
                DatePosted = DateTime.Now
                
            }
        };

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

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Stories()
        {
            return View(CurrentStories);
        }

        public IActionResult Story()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Story(StoryPost newStory)
        {
            
            CurrentStories.Add(newStory);
            
            return RedirectToAction("Stories");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}