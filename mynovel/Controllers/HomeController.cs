using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mynovel.Infrastructure;
using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INovel _novel;


        public HomeController(ILogger<HomeController> logger, INovel novel)
        {
            _logger = logger;
            _novel = novel;
        }

        public IActionResult Index()
        {
            var Novels = _novel.GetAll();
            return View(Novels);
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
