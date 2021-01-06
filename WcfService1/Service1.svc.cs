using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    //The type 'WcfService1.Service1', provided as the Service attribute value in the ServiceHost directive, or provided in the configuration element system.serviceModel/serviceHostingEnvironment/serviceActivations could not be found.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public List<Studentski_dom> domovi = new List<Studentski_dom>();
        public List<Student> student = new List<Student>();
        public List<StudentVDomu> studentje_v_domu = new List<StudentVDomu>();

        

        /*public Storitve()
        {
            DodelitevPodatkov();
        }*/

        public void DodelitevPodatkov()
        {


            Student student1 = new Student(1,051207215, "Jan", "Kačičnik", 1998);
            student.Add(student1);
            Student student2 = new Student(2,051051051, "Sandi", "Voršič", 1999);
            student.Add(student2);
            Student student3 = new Student(3,123123123, "Simon", "Turk", 1994);
            student.Add(student3);
            Student student4 = new Student(4,413413413, "David", "Novak", 1996);
            student.Add(student4);
            Student student5 = new Student(5,653635635, "Špela", "Horvat", 1995);
            student.Add(student5);
            Student student6 = new Student(6,67371477, "Simona", "Dogša", 1998);
            student.Add(student6);
            Student student7 = new Student(7,031809213, "Krunoslav", "Galič", 1997);
            student.Add(student7);

            Studentski_dom dom1 = new Studentski_dom(1, "Studentski dom 1", 1960);
            domovi.Add(dom1);
            Studentski_dom dom2 = new Studentski_dom(2, "Studentski dom 2", 1940);
            domovi.Add(dom2);
            Studentski_dom dom3 = new Studentski_dom(3, "Studentski dom 3", 1999);
            domovi.Add(dom3);
            Studentski_dom dom4 = new Studentski_dom(4, "Studentski dom 4", 2001);
            domovi.Add(dom4);

            StudentVDomu svd1 = new StudentVDomu( student1, dom1, 2, "enoposteljna");
            studentje_v_domu.Add(svd1);
            StudentVDomu svd2 = new StudentVDomu( student5, dom2, 1, "dvoposteljna");
            studentje_v_domu.Add(svd2);
            StudentVDomu svd3 = new StudentVDomu( student2, dom2, 1, "dvoposteljna");
            studentje_v_domu.Add(svd3);
            StudentVDomu svd4 = new StudentVDomu(student6, dom3, 2, "enoposteljna");
            studentje_v_domu.Add(svd4);
            StudentVDomu svd5 = new StudentVDomu( student4, dom4, 3, "enoposteljna");
            studentje_v_domu.Add(svd5);
            StudentVDomu svd6 = new StudentVDomu(student3, dom2, 4, "enoposteljna");
            studentje_v_domu.Add(svd6);
            StudentVDomu svd7 = new StudentVDomu( student7, dom1, 5, "dvoposteljna");
            studentje_v_domu.Add(svd7);






        }

        public bool vpis(string uporabniško_ime, string geslo)
        {
            Uporabnik PrijavljenŠtudent = new Uporabnik();

            PrijavljenŠtudent.Uporabniško_ime = uporabniško_ime;

            PrijavljenŠtudent.geslo = geslo;
            if (PrijavljenŠtudent.Uporabniško_ime == "admin" && PrijavljenŠtudent.geslo == "admin")
            {
                PrijavljenŠtudent.DaAdmin = true;
                return PrijavljenŠtudent.DaAdmin;
            }
            else
            {
                PrijavljenŠtudent.DaAdmin = false;
                return PrijavljenŠtudent.DaAdmin;
            }
        }

        
        public List<Student> PridobiVseStudente()
        {
            //return student;

            List<Student> studenti = new List<Student>();

            using (StudentskiDomoviContext studentskiDomoviContext = new StudentskiDomoviContext())
            {
                //studenti = studentskiDomoviContext.Student.ToList();
                return studentskiDomoviContext.Student.ToList();
            }

           // return studenti;
        }

        
        public List<Studentski_dom> PridobiVseDomove()
        {
            //return domovi;

            List<Studentski_dom> dom = new List<Studentski_dom>();

            using (StudentskiDomoviContext studentskiDomoviContext = new StudentskiDomoviContext())
            {
                dom = studentskiDomoviContext.Studentski_dom.ToList();
            }

            return dom;
        }

        
       /* public List<Student> PridobiVseStudenteVDomu(int stevilka_doma)
        {
            /*List<Student> studentje = new List<Student>();
            List<StudentVDomu> _studentje_v_domu = studentje_v_domu.Where(x => x.Dom.Stevilka_Doma == stevilka_doma).ToList();

            foreach (StudentVDomu studentVDomu in _studentje_v_domu)
            {
                studentje.Add(studentVDomu.Student);
            }

            return studentje;*/
        //}
    
        
        public Student VrniStudenta(int emso)
        {
            /*Student IzpisInformacijstudenta = new Student();

            foreach (Student podatek in student)
            {
                if (podatek.Emso == emso)
                {
                    IzpisInformacijstudenta = podatek;
                    break;
                }
            }
            return IzpisInformacijstudenta; ;*/
            using (StudentskiDomoviContext studentskiDomoviContext = new StudentskiDomoviContext())
            {
                Student IzpisInformacijstudenta = new Student();

                foreach (Student podatek in studentskiDomoviContext.Student)
                {
                    if (podatek.Emso == emso)
                    {
                        IzpisInformacijstudenta = podatek;
                        break;
                    }
                }

                return IzpisInformacijstudenta;
            }


        }

        
        public Studentski_dom VrniDom()
        {
            /*List<Studentski_dom> zacasniDomovi = new List<Studentski_dom>();

            List<KeyValuePair<Studentski_dom, int>> _domovi = new List<KeyValuePair<Studentski_dom, int>>();

            foreach (Studentski_dom studentski_Dom in domovi)
            {
                Studentski_dom dom = studentski_Dom;
                List<Student> studenti = new List<Student>();

                foreach (StudentVDomu item1 in studentje_v_domu)
                {
                    if (item1.Dom.Stevilka_Doma == studentski_Dom.Stevilka_Doma)
                    {
                        studenti.Add(item1.Student);
                    }
                }

                _domovi.Add(new KeyValuePair<Studentski_dom, int>(dom, student.Count));
            }

            int max = _domovi.Max(x => x.Value);

            foreach (KeyValuePair<Studentski_dom, int> item in _domovi)
            {
                if (item.Value == max)
                {
                    zacasniDomovi.Add(item.Key);
                }
            }

            return zacasniDomovi;*/

            int Zacasno_1 = 0;
            int Zacasno_2 = 0;
            Studentski_dom DomZnajvecStudenti = new Studentski_dom();
            for (int i = 1; i < studentje_v_domu.Count; i++)
            {
                if (i == 1)
                {
                    DomZnajvecStudenti = studentje_v_domu[i].Dom;
                }

                for (int j = 0; j < studentje_v_domu.Count; j++)
                {
                    if (studentje_v_domu[i - 1].Dom == studentje_v_domu[j].Dom)
                    {
                        Zacasno_1++;
                    }
                    if (studentje_v_domu[i].Dom == studentje_v_domu[j].Dom)
                    {
                        Zacasno_2++;
                    }
                }
                if (Zacasno_2 > Zacasno_1)
                {
                    DomZnajvecStudenti = studentje_v_domu[i].Dom;
                }
                Zacasno_1 = 0;
                Zacasno_2 = 0;
            }
            return DomZnajvecStudenti;
            
            }

        


        
        public Student IzpisNajstarejsega()
        {
            /* List<Student> seznam = new List<Student>();
             seznam = student.OrderBy(x => x.LetoRojstva).ToList();
             return seznam.First();


             /*
                         int datumRojstva = student.Max(x => x.LetoRojstva);

                         List<Student> lista = student.Where(x => x.LetoRojstva == datumRojstva).ToList();

                         return lista.First();*/


            using (StudentskiDomoviContext studentskiDomoviContext = new StudentskiDomoviContext())
            {
                List<Student> seznam = new List<Student>();
                seznam = studentskiDomoviContext.Student.OrderBy(x => x.LetoRojstva).ToList();
                //seznam =studentskiDomoviContext.Student.OrderBy(x => x.LetoRojstva).ToList();
                return seznam.First();
            }
        }

        
        public double IzpisPovprecneStarosti()
        {
            /*double Povprecna_leta = student.Average(x => x.LetoRojstva);
            //double povprecna = 2018 - Povprecna_leta;
            return Povprecna_leta;*/

            /*double povprecje = student.Average(x => x.LetoRojstva);

            return Math.Round(povprecje, 0);*/
            using (StudentskiDomoviContext studentskiDomoviContext = new StudentskiDomoviContext())
            {

                double povprecje = studentskiDomoviContext.Student.Average(x => x.LetoRojstva);

                return Math.Round(povprecje, 0);
            }
        }

        
        public bool DodajStudenta(int id, int emso, string ime, string priimek, int letoRojstva)
        {
            bool StudentDodan = false;

            using (StudentskiDomoviContext kontekst = new StudentskiDomoviContext())
            {
                int steviloStudentov = kontekst.Student.Count();

                Student novStudent = new Student(id, emso, ime, priimek, letoRojstva);

                kontekst.Student.Add(novStudent);
                kontekst.SaveChanges();


                if (steviloStudentov < kontekst.Student.Count())
                {
                    StudentDodan = true;
                }

                return StudentDodan;
            }

        }

        
        public bool DodajStudentskiDom(int stevilka_doma, string ime_doma, int leto_nastanka)
        {
            bool DomDodan = false;

            using (StudentskiDomoviContext kontekst = new StudentskiDomoviContext())
            {
                int steviloDomov = kontekst.Studentski_dom.Count();

                Studentski_dom novStudentskiDom = new Studentski_dom(stevilka_doma, ime_doma, leto_nastanka);

                kontekst.Studentski_dom.Add(novStudentskiDom);
                kontekst.SaveChanges();


                if (steviloDomov < kontekst.Studentski_dom.Count())
                {
                    DomDodan = true;
                }

                return DomDodan;
            }

        }

        
        public bool DodajStudentaVDomu(Student student, Studentski_dom studentski_dom, int dolzina_bivanja, string tip)
        {
            bool StudentVDomuDodan = false;

            using (StudentskiDomoviContext kontekst = new StudentskiDomoviContext())
            {
                int steviloDomov = kontekst.Studentski_dom.Count();

                StudentVDomu novStudentVDomu = new StudentVDomu(student, studentski_dom, dolzina_bivanja, tip);

                kontekst.Student_v_domu.Add(novStudentVDomu);
                kontekst.SaveChanges();


                if (steviloDomov < kontekst.Student_v_domu.Count())
                {
                    StudentVDomuDodan = true;
                }

                return StudentVDomuDodan;
            }

        }

        
        public bool OdstraniStudenta(int id)
        {
            bool studentOdstranjen = false;

            using (StudentskiDomoviContext kontekst = new StudentskiDomoviContext())
            {
                int StariStudentje = kontekst.Student.Count();

                foreach (var student in kontekst.Student)
                {
                    if (student.Id == id)
                    {
                        kontekst.Student.Remove(student);
                        break;
                    }

                }

                OdstraniStudentaizDomov(id);

                kontekst.SaveChanges();


                if (StariStudentje > kontekst.Student.Count())
                {
                    studentOdstranjen = true;
                }
            }
            return studentOdstranjen;


        }

        
        public bool OdstraniDom(int id)
        {
            bool domOdstranjen = false;

            using (StudentskiDomoviContext kontekst = new StudentskiDomoviContext())
            {
                int StariDomovi = kontekst.Studentski_dom.Count();

                foreach (var dom in kontekst.Studentski_dom)
                {
                    if (dom.Id == id)
                    {
                        kontekst.Studentski_dom.Remove(dom);
                        break;
                    }

                }

                OdstraniDomIzStudentVDomu(id);

                kontekst.SaveChanges();


                if (StariDomovi > kontekst.Studentski_dom.Count())
                {
                    domOdstranjen = true;
                }
            }
            return domOdstranjen;
        }


        
        public bool OdstraniStudentaizDomov(int id)
        {
            bool studentVDomuOdstranjen = false;

            using (StudentskiDomoviContext kontekst = new StudentskiDomoviContext())
            {
                int StariStudentVDomu = kontekst.Student_v_domu.Count();

                var povp = kontekst.Student_v_domu.Include("Student").Include("Dom").ToList();

                foreach (var student_v_domu in povp)
                {
                    if (student_v_domu.Student.Id == id)
                    {
                        kontekst.Student_v_domu.Remove(student_v_domu);
                    }

                }

                kontekst.SaveChanges();


                if (StariStudentVDomu > kontekst.Student.Count())
                {
                    studentVDomuOdstranjen = true;
                }
            }
            return studentVDomuOdstranjen;
        }

        
        public bool OdstraniDomIzStudentVDomu(int id)
        {
            bool domIzStudentaVDomuOdstranjen = false;

            using (StudentskiDomoviContext kontekst = new StudentskiDomoviContext())
            {
                int StariStudentVDomu = kontekst.Student_v_domu.Count();

                var povp = kontekst.Student_v_domu.Include("Student").Include("Dom").ToList();

                foreach (var student_v_domu in povp)
                {
                    if (student_v_domu.Dom.Id == id)
                    {
                        kontekst.Student_v_domu.Remove(student_v_domu);
                    }

                }

                kontekst.SaveChanges();

                if (StariStudentVDomu > kontekst.Studentski_dom.Count())
                {
                    domIzStudentaVDomuOdstranjen = true;
                }
            }
            return domIzStudentaVDomuOdstranjen;
        }

       
        public bool UrediStudenta(int idUporabnika, int emso, string Ime, string Priimek, int leto_rojstva)
        {
            bool StudentUrejen = false;

            using (StudentskiDomoviContext kontekst = new StudentskiDomoviContext())
            {
                Student u = kontekst.Student.First(uporabnik => uporabnik.Id == idUporabnika);
                u.Emso = emso;
                u.Ime = Ime;
                u.Priimek = Priimek;
                u.LetoRojstva = leto_rojstva;
                //u.Spol=spol;

                kontekst.SaveChanges();
                StudentUrejen = true;
            }
            return StudentUrejen;
        }


        
        public bool UrediDom(int Id, string ime, int stevilkadoma)
        {
            bool DomUrejen = false;

            using (StudentskiDomoviContext kontekst = new StudentskiDomoviContext())
            {
                Studentski_dom u = kontekst.Studentski_dom.First(uporabnik => uporabnik.Id == Id);
                u.Ime = ime;
                u.Stevilka_Doma = stevilkadoma;
                kontekst.SaveChanges();
                DomUrejen = true;
            }
            return DomUrejen;
        }


    
}
}
