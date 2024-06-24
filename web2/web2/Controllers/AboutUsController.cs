using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web2.Controllers
{
    public class AboutUsController : Controller
    {
        
        public ActionResult Index()
        {
            Models.User u = new Models.User();

            u.FirstName = "Megan";
            u.LastName = "Noel";
            u.UserID = "mnoel";
            u.Password = "mnoel8";
            u.Email = "mnoel@gmail";

           return View(u);
        }

        [HttpPost]
        public ActionResult Index(FormCollection col) {

            if (col["btnSubmit"] == "more") {               
                return RedirectToAction("More", "AboutUs");
            }

            if (col["btnSubmit"] == "close") {
                return RedirectToAction("Index", "Home");
            }


            return View();
        }


        public ActionResult More() {
            Models.User u = new Models.User();

            u.FirstName = "Megan";
            u.LastName = "Noel";
            u.UserID = "mnoel";
            u.Password = "mnoel8";
            u.Email = "mnoel@gmail";

            return View(u);
        }

        [HttpPost]
        public ActionResult More(FormCollection col) {
            return RedirectToAction("Index", "AboutUs");
        }




    }
}