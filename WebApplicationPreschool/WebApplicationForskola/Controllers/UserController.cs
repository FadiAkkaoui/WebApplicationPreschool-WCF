using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationForskola.Models;

namespace WebApplicationForskola.Controllers
{
    public class UserController : Controller
    {
        public ActionResult LoginA()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginA(UserA inloggning)
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