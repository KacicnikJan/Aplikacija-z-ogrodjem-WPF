using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.Serialization;

namespace WcfService1
{
    [DataContract]
    public class StudentskiDomoviContext:DbContext

    {
        [DataMember]
        public DbSet<Student> Student { get; set; }
        [DataMember]
        public DbSet<StudentVDomu> Student_v_domu { get; set; }
        [DataMember]
        public DbSet<Studentski_dom> Studentski_dom { get; set; }

        public StudentskiDomoviContext()
        {
            Database.SetInitializer<StudentskiDomoviContext>(new PodatkovniDBInitializer());

            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public class PodatkovniDBInitializer : CreateDatabaseIfNotExists<StudentskiDomoviContext>
        {
            protected override void Seed(StudentskiDomoviContext kontekst)
            {
                Student student1 = new Student(1,051207215, "Jan", "Kačičnik", 1998);
                kontekst.Student.Add(student1);
                Student student2 = new Student(2,051051051, "Sandi", "Voršič", 1999);
                kontekst.Student.Add(student2);
                Student student3 = new Student(3,123123123, "Simon", "Turk", 1994);
                kontekst.Student.Add(student3);
                Student student4 = new Student(4,413413413, "David", "Novak", 1996);
                kontekst.Student.Add(student4);
                Student student5 = new Student(5,653635635, "Špela", "Horvat", 1995);
                kontekst.Student.Add(student5);
                Student student6 = new Student(6,737147627, "Simona", "Dogša", 1998);
                kontekst.Student.Add(student6);
                Student student7 = new Student(7,031809213, "Krunoslav", "Galič", 1997);
                kontekst.Student.Add(student7);

                Studentski_dom dom1 = new Studentski_dom(1, "Studentski dom 1", 1960);
                kontekst.Studentski_dom.Add(dom1);
                Studentski_dom dom2 = new Studentski_dom(2, "Studentski dom 2", 1940);
                kontekst.Studentski_dom.Add(dom2);
                Studentski_dom dom3 = new Studentski_dom(3, "Studentski dom 3", 1999);
                kontekst.Studentski_dom.Add(dom3);
                Studentski_dom dom4 = new Studentski_dom(4, "Studentski dom 4", 2001);
                kontekst.Studentski_dom.Add(dom4);

                StudentVDomu svd1 = new StudentVDomu( student1, dom1, 2, "enoposteljna");
                kontekst.Student_v_domu.Add(svd1);
                StudentVDomu svd2 = new StudentVDomu( student5, dom2, 1, "dvoposteljna");
                kontekst.Student_v_domu.Add(svd2);
                StudentVDomu svd3 = new StudentVDomu( student2, dom3, 1, "dvoposteljna");
                kontekst.Student_v_domu.Add(svd3);
                StudentVDomu svd4 = new StudentVDomu( student6, dom3, 2, "enoposteljna");
                kontekst.Student_v_domu.Add(svd4);
                StudentVDomu svd5 = new StudentVDomu(student4, dom4, 3, "enoposteljna");
                kontekst.Student_v_domu.Add(svd5);
                StudentVDomu svd6 = new StudentVDomu( student3, dom2, 4, "enoposteljna");
                kontekst.Student_v_domu.Add(svd6);
                StudentVDomu svd7 = new StudentVDomu( student7, dom1, 5, "dvoposteljna");
                kontekst.Student_v_domu.Add(svd7);



                base.Seed(kontekst);
            }

        }


      

    }

}