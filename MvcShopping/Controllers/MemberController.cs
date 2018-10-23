using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcShopping.Models;
using System.Web;

namespace MvcShopping.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Member member)
        {
            return View();
        }

        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        public IActionResult Login(string email, string password, string returnUrl)
        {
            if (ValidateUser(email, password))
            {

            }

            return View();
        }
    }
}