using Microsoft.AspNetCore.Mvc;
using mynovel.Infrastructure;
using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUser _Users;

        public UsersController(IUser users)
        {
            _Users = users;
        }

        public  IActionResult Index()
        {

       

            return View();
        }
        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username,string password)
        {
          var user=  _Users.IsAuthorized(username, password);
            if(user!=null)
            {
                return Redirect("/home");
            }

           return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Reader user)
        {
            _Users.Insert(user);
            _Users.Save();
            return RedirectToAction("Login");
        }


    }
}
