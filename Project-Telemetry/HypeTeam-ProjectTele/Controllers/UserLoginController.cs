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
        
        [HttpPost]
        public ActionResult Login(UserLogin users)
        {
            if (ModelState.IsValid)
            {
                //message will collect the String value from the model method.
                String message = users.LoginProcess(users.userID, users.password);
                //RedirectToAction("actionName/ViewName_ActionResultMethodName", "ControllerName");
                if (message.Equals("1"))
                {
                    //this will add cookies for the username.
                    //Response.Cookies.Add(new HttpCookie("Users1", users.username));
                    //This is a different Controller for the User Homepage. Redirecting after successful process.
                    return RedirectToAction("Home", "Index");
                }
                else
                    ViewBag.ErrorMessage = message;
            }
            return View(users);
        }

    }
}