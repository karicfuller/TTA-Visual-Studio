using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //method - return type is ActionResult
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Kari",
                LastName = "Fuller"
            };

            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            return View();
        }
    }
}

///Home/Contact
///Controller routed to: HomeController
///Method run: Contact()
///View folder to look in: Home
///File to return: Constact.cshtml