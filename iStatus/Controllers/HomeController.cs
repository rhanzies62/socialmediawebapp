using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Services.Methods;
using BackEnd.Services.Models.Entities;
using BackEnd.Services.Models;
namespace iStatus.Controllers
{
    public class HomeController : Controller
    {

        AccountService accountService = new AccountService();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult AboutMe()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(User user)
        {
           accountService.Save(user);
           return View();
        }

       
    }
}