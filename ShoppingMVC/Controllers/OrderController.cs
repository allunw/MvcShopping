using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingMVC.Models;

namespace ShoppingMVC.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {        
        public ActionResult Complete()
        {
            return View();
        }

        [HttpPost]        
        public ActionResult Complete(FormCollection form)
        {

            //todo
            return RedirectToAction("Index", "Home");
        }
    }
}