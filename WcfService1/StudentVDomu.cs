using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class StudentVDomu
    {
        private int id;
        
        
        private  Student student;
        private Studentski_dom dom;
        private string tip;
        private int dolzina_bivanja;

        [Key, DataMember]
        public int Id
        { get; set; }
        [DataMember]
        public virtual Student Student
        { get; set; }
        [DataMember]
        public virtual Studentski_dom Dom
        { get; set; }
        [DataMember]
        public string Tip
        { get; set; }
        [DataMember]
        public int Dolzina_bivanja
        { get; set; }


        public virtual Student Studentt { get; set; }

        [ForeignKey(nameof(st_dom)), DataMember]
        public int Id_doma { get; set; }
        [ForeignKey("Id_doma"), DataMember]

        public virtual Studentski_dom st_dom { get; set; }
        public StudentVDomu()
        { }

        public StudentVDomu( Student student, Studentski_dom dom, int dolzina_bivanja, string tip)
        {
            
            this.Student = student;
            this.Dom = dom;
            this.Dolzina_bivanja = dolzina_bivanja;
            this.Tip = tip;
            
        }
    }
}