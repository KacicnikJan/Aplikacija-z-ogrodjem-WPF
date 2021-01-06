using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class Studentski_dom
    {
        private int id;
        private int stevilka_doma;
        private string ime;        
        private int leto_nastanka;

        [Key, DataMember]
        public int Id
        { get; set; }
        [DataMember]
        public int Stevilka_Doma
        { get; set; }
        [DataMember]
        public string Ime
        { get; set; }
        [DataMember]
        public int Leto_Nastanka
        { get; set; }
      

        public Studentski_dom()
        { }

        public Studentski_dom(int stevilka_doma, string ime, int leto_nastanka)
        {
            
            this.Stevilka_Doma = stevilka_doma;
            this.Ime = ime;         
            this.Leto_Nastanka = leto_nastanka;
           
        }

    }
}
