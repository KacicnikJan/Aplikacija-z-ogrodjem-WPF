using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class Student
    {
        private int id;
        private int emso;
        private string ime;
        private string priimek;
        private int letoRojstva;
        //private string spol;

        [Key, DataMember]
        public int Id
        { get; set; }
        [DataMember]
        public int Emso
        { get; set; }
        [DataMember]
        public string Ime
        { get; set; }
        [DataMember]
        public string Priimek
        { get; set; }
        [DataMember]
        public int LetoRojstva
        { get; set; }
        
        // public string Spol
        // { get; set; }


        public Student()
        { }

        public Student(int id, int emso, string ime, string priimek, int letoRojstva)
        {
            this.id = id;
            this.Emso = emso;
            this.Ime = ime;
            this.Priimek = priimek;
            this.LetoRojstva = letoRojstva;
           // this.Spol = spol;
        }

    }
}
