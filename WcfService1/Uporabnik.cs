using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class Uporabnik
    {
        
        [DataMember]
        public string Uporabniško_ime { get; set; }
        [DataMember]
        public string geslo { get; set; }
        [DataMember]
        public bool DaAdmin { get; set; }

        public Uporabnik()
        {

        }
        public Uporabnik(string uporabnisko_ime, string geslo, bool daAdmin)
        {
            this.Uporabniško_ime = uporabnisko_ime;
            this.geslo = geslo;
            this.DaAdmin = daAdmin;
        }
    }
}