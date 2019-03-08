using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Web.Models.Login;

namespace Web.Controllers
{
    public class UserController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {           
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel user)
        {
            if(ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(user.Username, true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login", user);
            }
        }

    }
}