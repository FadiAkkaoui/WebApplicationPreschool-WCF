using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationForskola.ServiceReference2;

namespace WebApplicationForskola.Controllers
{
    public class StatusController : Controller
    {
        // GET: Status
        public ActionResult Index()
        {
            ServiceReference2.Service1Client Klient = new ServiceReference2.Service1Client();
            List<ServiceReference2.StatusClass> lista = Klient.GetStatusLista().ToList();
            return View(lista);
        }
    }
}