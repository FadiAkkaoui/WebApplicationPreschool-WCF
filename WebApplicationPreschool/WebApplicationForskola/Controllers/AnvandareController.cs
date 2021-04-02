using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationForskola.Controllers
{
    public class AnvandareController : Controller
    {
        [Authorize]
        public ActionResult Anvandare()
        {
            return View();
        }
    }
}