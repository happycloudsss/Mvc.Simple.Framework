using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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
        public ActionResult Login(string username,string password)
        {
            if(username!=null && password!=null)
            {
                FormsAuthentication.SetAuthCookie(username, true);
            }
            return RedirectToAction("Index", "Home");
        }

    }
}