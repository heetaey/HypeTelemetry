using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HypeTeam_ProjectTele.Models;
using HypeTeam_ProjectTele.Backend;

namespace HypeTeam_ProjectTele.Controllers
{
    public class ReportController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "Report";

            var myViewModel = new ReportViewModel();

            myViewModel.LogViewModel = LogBackend.Instance.Index();
            myViewModel.NumberOfUsers = LogBackend.Instance.numUser();

            return View(myViewModel);
        }

        /// <summary>
        /// Look up the record passed in
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Read(string id = null)
        {
            ViewData["Title"] = "Report " + id;
            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = LogBackend.Instance.Read(id);
            return View(myData);
        }

        /// <summary>
        /// Show the Data to Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id = null)
        {
            ViewData["Title"] = "Delete " + id;
            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = LogBackend.Instance.Read(id);
            return View(myData);
        }

        /// <summary>
        /// Delete Action
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed([Bind(Include = "ID")] string id)
        {
            ViewData["Title"] = "Delete " + id;

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            // If no ID passed in, jump to the Index page
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var myData = LogBackend.Instance.Read(id);
            if (myData != null)
            {
                LogBackend.Instance.Delete(id);
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Create Page
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            ViewData["Title"] = "Create New Log";
            return View();
        }

        /// <summary>
        /// Create Action
        /// </summary>
        /// <param name="data">The Phone, and EventType, and Value</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include =
            "Value," +
            "PatientID," +
            "Location," +
            "UserID," +
            "PhoneHome," +
            "PhoneID," +
            "AppVersion," +
            "OsVersion," +
            "LightLevel," +
            "SaturationLevel," +
            "HueLevel," +
            "ClinicID," +
            "")] LogModel data)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            // If no data passed in, jump to the Index page
            if (data == null)
            {
                return RedirectToAction("Index");
            }

            var myData = LogBackend.Instance.Create(data);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Update Page
        /// </summary>
        /// <returns></returns>
        public ActionResult Update(string id = null)
        {
            ViewData["Title"] = "Update Log " + id;

            var myData = LogBackend.Instance.Read(id);
            return View(myData);
        }

        /// <summary>
        /// Update Action
        /// </summary>
        /// <param name="data">The Phone, and EventType, and Value</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update([Bind(Include =
            "ID," +
            "Value," +
            "Location," +
            "UserID," +
            "PhoneHome," +
            "PhoneID," +
            "AppVersion," +
            "ClinicID," +
            "")] LogModel data)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            // If no data passed in, jump to the Index page
            if (data == null)
            {
                return RedirectToAction("Index");
            }

            var myData = LogBackend.Instance.Update(data);
            return RedirectToAction("Index");
        }
    }
}
