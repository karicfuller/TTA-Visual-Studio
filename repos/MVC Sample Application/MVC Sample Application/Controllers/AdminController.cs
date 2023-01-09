using MVC_Sample_Application.Models;
using MVC_Sample_Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sample_Application.Controllers
{
    public class AdminController : Controller
    {
        //Get: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signups = db.SignUps;
                var signupVMs = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVM = new SignupVm();
                    signupVM.Id = signup.Id;
                    signupVM.FirstName = signup.FirstName;
                    signupVM.LastName = signup.LastName;
                    signupVM.EmailAddress = signup.EmailAddress;
                    signupVMs.Add(signupVM);
                }
                return View(signupVMs);
            }
        }
    }
}