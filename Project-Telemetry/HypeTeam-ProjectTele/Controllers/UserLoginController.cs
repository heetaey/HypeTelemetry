using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HypeTeam_ProjectTele.Controllers;
using HypeTeam_ProjectTele.Models;

namespace HypeTeam_ProjectTele.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: /UserLogin/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
    }
}