using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationAdmin.Models;

namespace WebApplicationAdmin.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult LoginB()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginB(UserB inloggning)
        {
            if (inloggning.Username == null || inloggning.Password == null)
            {
                ModelState.AddModelError("", "Ett värde måste matas in, testa igen");
                return View();
            }
            bool validUser = false;
            validUser = System.Web.Security.FormsAuthentication.Authenticate(inloggning.Username, inloggning.Password);
            if (validUser == true)
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(inloggning.Username, false);
            }
            ModelState.AddModelError("", "Ej inloggad, testa igen");
            return View();
        }
    }
}