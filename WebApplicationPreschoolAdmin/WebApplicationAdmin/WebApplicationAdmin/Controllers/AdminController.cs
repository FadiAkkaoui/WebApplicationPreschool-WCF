using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationAdmin.Models;
using WebApplicationAdmin.ServiceReference2;

namespace WebApplicationAdmin.Controllers
{
    public class AdminController : Controller
    {
        [Authorize]
        public ActionResult Administrator()
        {
            return View();
        }
        public ActionResult Ansokningar()
        {
            ServiceReference2.Service1Client Klient = new ServiceReference2.Service1Client();
            List<ServiceReference2.BarnClass> lista = Klient.GetBarnLista().ToList();
            return View(lista);
        }
        public ActionResult Detaljer()
        {
            ServiceReference2.Service1Client Klient = new ServiceReference2.Service1Client();
            List<ServiceReference2.BarnClass> Blista = Klient.GetBarnLista().ToList();
            return View(Blista);
        }
        public ActionResult DetaljerV()
        {
            ServiceReference2.Service1Client Klient = new ServiceReference2.Service1Client();
            List<ServiceReference2.BarnClass> Blista = Klient.GetBarnLista().ToList();
            return View(Blista);
        }
        public ActionResult Bedom()
        {      
            return View();
        }
        [HttpPost]
        public ActionResult Bedom(StatusTable nyStatus) 
        {
            ServiceReference2.Service1Client klient = new ServiceReference2.Service1Client();
            StatusClass nyB = new StatusClass();
            nyB.Bfyrasiffror = nyStatus.Bfyrasiffror;
            nyB.Bedomning = nyStatus.Bedomning;
            nyB.Datum = nyStatus.Datum;
            nyB.Kommentar = nyStatus.Kommentar;
            klient.CreateStatus(nyStatus);
            return RedirectToAction("Ansokningar", "Admin");
        }
        public ActionResult Radera()
        {
            return View();
        }          
        [HttpPost] 
        public ActionResult Radera(IdnClass i )
        {
            ServiceReference2.Service1Client Klient = new ServiceReference2.Service1Client();
            Klient.DeleteBarn(i.id);
            return RedirectToAction("Ansokningar","Admin");
        }
    }
}