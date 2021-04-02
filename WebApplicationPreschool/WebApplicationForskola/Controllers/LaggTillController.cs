using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationForskola.ServiceReference2;

namespace WebApplicationForskola.Controllers
{
    public class LaggTillController : Controller
    {
        public ActionResult AddBarn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBarn(BarnTable NyBarn)
        {
            ServiceReference2.Service1Client klient = new ServiceReference2.Service1Client();
            BarnClass nyB = new BarnClass();
            nyB.Bfyrasiffror = NyBarn.Bfyrasiffror;
            nyB.Bfodelsedatum = NyBarn.Bfodelsedatum;
            nyB.Bfornamn = NyBarn.Bfornamn;
            nyB.Befternamn = NyBarn.Befternamn;
            nyB.Bpostadress = NyBarn.Bpostadress;
            nyB.Bpostnummer = NyBarn.Bpostnummer;
            nyB.Bpostort = NyBarn.Bpostort;
            nyB.Forskola = NyBarn.Forskola;
            nyB.Vfyrasiffror = NyBarn.Vfyrasiffror;
            nyB.Vfodelsedatum = NyBarn.Vfodelsedatum;
            nyB.Vfornamn = NyBarn.Vfornamn;
            nyB.Vefternamn = NyBarn.Vefternamn;
            nyB.Vpostnummer = NyBarn.Vpostnummer;
            nyB.Vpostort = NyBarn.Vpostort;
            nyB.Vpostadress = NyBarn.Vpostadress;
            nyB.Vhemtelefon = NyBarn.Vhemtelefon;
            nyB.Vmobiltelefon = NyBarn.Vmobiltelefon;
            klient.CreateBarn(NyBarn);
            return RedirectToAction("Anvandare", "Anvandare");

        }
    }
}