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
            ViewData["Title"] = "Dashboard";
            var myViewModel = new LogViewModel();
            var myData = new HomeViewModel
            {
                LogCount = myViewModel.LogList.Count
            };
            return View(myData);
        }
    }
}