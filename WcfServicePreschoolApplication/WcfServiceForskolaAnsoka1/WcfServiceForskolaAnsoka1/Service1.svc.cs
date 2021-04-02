using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceForskolaAnsoka1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool CreateBarn(BarnTable NyBarn)
        {
            try
            {
                using (FSDDatabaseEntities dbB = new FSDDatabaseEntities())
                {
                    BarnTable bt = new BarnTable();
                    bt.Bfyrasiffror = NyBarn.Bfyrasiffror;
                    bt.Bfodelsedatum = NyBarn.Bfodelsedatum;
                    bt.Bfornamn = NyBarn.Bfornamn;
                    bt.Befternamn = NyBarn.Befternamn;
                    bt.Bpostadress = NyBarn.Bpostadress;
                    bt.Bpostnummer = NyBarn.Bpostnummer;
                    bt.Bpostort = NyBarn.Bpostort;
                    bt.Vfyrasiffror = NyBarn.Vfyrasiffror;
                    bt.Vfodelsedatum = NyBarn.Vfodelsedatum;
                    bt.Vfornamn = NyBarn.Vfornamn;
                    bt.Vefternamn = NyBarn.Vefternamn;
                    bt.Vpostnummer = NyBarn.Vpostnummer;
                    bt.Vpostort = NyBarn.Vpostort;
                    bt.Vpostadress = NyBarn.Vpostadress;
                    bt.Vhemtelefon = NyBarn.Vhemtelefon;
                    bt.Vmobiltelefon = NyBarn.Vmobiltelefon;
                    bt.Forskola = NyBarn.Forskola;
                    dbB.BarnTable.Add(NyBarn);
                    dbB.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool CreateStatus(StatusTable NyStatus)
        {
            try
            {
                using (FSDDatabaseEntities dbV = new FSDDatabaseEntities())
                {
                    StatusTable bt = new StatusTable();
                    bt.Bfyrasiffror = NyStatus.Bfyrasiffror;
                    bt.Bedomning = NyStatus.Bedomning;
                    bt.Datum = NyStatus.Datum;
                    bt.Kommentar = NyStatus.Kommentar;
                    dbV.StatusTable.Add(NyStatus);
                    dbV.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteBarn(int i)
        {
            try
            {
                using (FSDDatabaseEntities dbB = new FSDDatabaseEntities())
                {
                    BarnTable deleteb = dbB.BarnTable.Find(i);
                    dbB.BarnTable.Remove(deleteb);
                    dbB.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteStatus(int Fyrasiffror)
        {
            try
            {
                using (FSDDatabaseEntities dbB = new FSDDatabaseEntities())
                {
                    StatusTable deleteb = dbB.StatusTable.Find(Fyrasiffror);
                    dbB.StatusTable.Remove(deleteb);
                    dbB.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public List<BarnClass> GetBarnLista()
        {
            using (FSDDatabaseEntities dbRB = new FSDDatabaseEntities())
            {
                List<BarnClass> returDataB = new List<BarnClass>();
                var dbBarnListan = dbRB.BarnTable.ToList();
                foreach (var barn in dbBarnListan)
                {
                    BarnClass returBarn = new BarnClass();
                    returBarn.Bfyrasiffror = barn.Bfyrasiffror;
                    returBarn.Bfodelsedatum = barn.Bfodelsedatum;
                    returBarn.Bfornamn = barn.Bfornamn;
                    returBarn.Befternamn = barn.Befternamn;
                    returBarn.Bpostadress = barn.Bpostadress;
                    returBarn.Bpostnummer = barn.Bpostnummer;
                    returBarn.Bpostort = barn.Bpostort;
                    returBarn.Forskola = barn.Forskola;
                    returBarn.Vfyrasiffror = barn.Vfyrasiffror;
                    returBarn.Vfodelsedatum = barn.Vfodelsedatum;
                    returBarn.Vfornamn = barn.Vfornamn;
                    returBarn.Vefternamn = barn.Vefternamn;
                    returBarn.Vpostnummer = barn.Vpostnummer;
                    returBarn.Vpostort = barn.Vpostort;
                    returBarn.Vpostadress = barn.Vpostadress;
                    returBarn.Vhemtelefon = barn.Vhemtelefon;
                    returBarn.Vmobiltelefon = barn.Vmobiltelefon;
                    returDataB.Add(returBarn);
                }
                return returDataB;

            }
        }
        public List<StatusClass> GetStatusLista()
        {

            using (FSDDatabaseEntities dbRV = new FSDDatabaseEntities())
            {
                List<StatusClass> returDataV = new List<StatusClass>();
                var dbStatusLista = dbRV.StatusTable.ToList();
                foreach (var item in dbStatusLista)
                {
                    StatusClass returStatus = new StatusClass();
                    returStatus.Bfyrasiffror = item.Bfyrasiffror;
                    returStatus.Bedomning = item.Bedomning;
                    returStatus.Datum = item.Datum;
                    returStatus.Kommentar = item.Kommentar;
                    returDataV.Add(returStatus);
                }
                return returDataV;
            }
        }

    }
}

