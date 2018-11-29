using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

using System.Web.Script.Serialization;

using WebApplication4.Models;

namespace WebApplication4
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        
        public ActionResult Index()
        {
            

           
                var json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/photos");



            JavaScriptSerializer js = new JavaScriptSerializer();
            JsonFeedModels[] album = js.Deserialize<JsonFeedModels[]>(json);


            ViewBag.album = album;


            return View();
            
            
        }

        public Boolean isValidated() {


            return false;
        }


        [HttpPost]
        public ActionResult login()
        {
            var uname = Request["u_name"];
            var pass = Request["pwd"];
            var msg = "";
            bool isValidated = false;

            if (uname == "" || pass == "") {
                msg = "Validation error : please enter valid data";
                isValidated = false;

            }
            else {
                msg = "Validation Successful";
                isValidated = true;

            }


            ViewData["msg"] = msg;
            ViewBag.isValidated = isValidated;

            return View();
        }

    }
}