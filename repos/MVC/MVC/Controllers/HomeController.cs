using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Kari";
            user.LastName = "Fuller";
            user.Age = 46;

            return View(user);            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}