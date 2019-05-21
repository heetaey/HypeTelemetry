using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HypeTeam_ProjectTele.Models;

namespace HypeTeam_ProjectTele.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var myData = new HomeViewModel
            {

            };
            return View();
        }

        public ActionResult Report()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}