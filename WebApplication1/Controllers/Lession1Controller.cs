using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Lession1Controller : Controller
    {
        // GET: Lession1
        public ActionResult Index()
        {
            return View();
        }

        //protected override void HandleUnknownAction(string actionName)
        //{
        //    Response.Redirect("http://www.google.com");
        //    base.HandleUnknownAction(actionName);
        //}


    }
}