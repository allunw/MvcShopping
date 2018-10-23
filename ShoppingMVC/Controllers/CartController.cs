using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingMVC.Controllers
{
    public class CartController : Controller
    {   
        [HttpPost]
        public ActionResult AddToCart(int ProductId, int Amount = 1)
        {
            return View();
        }
                
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateAmount(int ProductId, int NewAmount)
        {
            return View();
        }
    }
}