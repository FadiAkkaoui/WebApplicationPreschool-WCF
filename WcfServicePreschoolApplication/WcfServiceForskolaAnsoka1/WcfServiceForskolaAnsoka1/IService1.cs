using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceForskolaAnsoka1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool CreateBarn(BarnTable NyBarn);
     
        [OperationContract]
        bool CreateStatus(StatusTable NyStatus);
        [OperationContract]
        bool DeleteBarn(int i);
        [OperationContract]
        bool DeleteStatus(int Fyrasiffror);
        [OperationContract]
        List<BarnClass> GetBarnLista();
        [OperationContract]
        List<StatusClass> GetStatusLista();
        
    
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class BarnClass
    {
        [DataMember]
        public int Bfyrasiffror { get; set; }
        [DataMember]
        public int Bfodelsedatum { get; set; }
        [DataMember]
        public string Bfornamn { get; set; }
        [DataMember]
        public string Befternamn { get; set; }
        [DataMember]
        public int Bpostnummer { get; set; }
        [DataMember]
        public string Bpostort { get; set; }
        [DataMember]
        public string Bpostadress { get; set; }
        [DataMember]
        public string Forskola { get; set; }
        [DataMember]
        public int Vfyrasiffror { get; set; }
        [DataMember]
        public int Vfodelsedatum { get; set; }
        [DataMember]
        public string Vfornamn { get; set; }
        [DataMember]
        public string Vefternamn { get; set; }
        [DataMember]
        public int Vpostnummer { get; set; }
        [DataMember]
        public string Vpostort { get; set; }
        [DataMember]
        public string Vpostadress { get; set; }
        [DataMember]
        public int Vhemtelefon { get; set; }
        [DataMember]
        public int Vmobiltelefon { get; set; }
     }
    public class StatusClass
    {
        [DataMember]
        public int Bfyrasiffror { get; set; }
        [DataMember]
        public string Bedomning { get; set; }
        [DataMember]
        public DateTime Datum { get; set; }
        [DataMember]
        public string Kommentar { get; set; }

    }
    public class IdClass
    {
        [DataMember]
        public int id { get; set; }

    }
}