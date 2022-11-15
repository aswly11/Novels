using Microsoft.AspNetCore.Mvc;
using mynovel.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Controllers
{
    public class NovelsController : Controller
    {
        private readonly INovel _Novel;

        public NovelsController(INovel novel)
        {
            _Novel = novel;
        }

        public IActionResult Index()
        {

            var Novels =  _Novel.GetAll();

            return  View(Novels);
        }
        [HttpGet]
        public  IActionResult Create()
        {

        
            return View();
        }
    }
}
