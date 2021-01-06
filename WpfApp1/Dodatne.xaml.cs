using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Dodatne.xaml
    /// </summary>
    public partial class Dodatne : Window
    {
        ServiceReference1.Service1Client StudentskiDomovi = new ServiceReference1.Service1Client();

        public static Dodatne dodatne1;

        private List<ServiceReference1.Student> studentje;
        private List<ServiceReference1.Studentski_dom> studentski_domovi;


        public void NapolniTabeloStudentov()
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            List<ServiceReference1.Student> _studentje = service.PridobiVseStudente().ToList();

            DataTable studentje = new DataTable();

            studentje.Columns.Add("ID");
            studentje.Columns.Add("Ime");
            studentje.Columns.Add("Priimek");
            studentje.Columns.Add("Leto rojstva");
            studentje.Columns.Add("EMSO");

            foreach (ServiceReference1.Student student in _studentje)
            {
                DataRow studentcolumns = studentje.NewRow();
                studentcolumns["ID"] = student.Id;
                studentcolumns["Ime"] = student.Ime;
                studentcolumns["Priimek"] = student.Priimek;
                studentcolumns["Leto rojstva"] = student.LetoRojstva;
                studentcolumns["EMSO"] = student.Emso;

                studentje.Rows.Add(studentcolumns);
            }

            gridstudentje.ItemsSource = studentje.DefaultView;

        }

        public void NapolniTabeloDomov()
        {
            ServiceReference1.Service1Client StudentskiDomovi = new ServiceReference1.Service1Client();

            List<ServiceReference1.Studentski_dom> _domovi = StudentskiDomovi.PridobiVseDomove().ToList();

            DataTable domovi = new DataTable();

            domovi.Columns.Add("ID");
            domovi.Columns.Add("Stevilka doma");
            domovi.Columns.Add("Ime doma");
            

            foreach (ServiceReference1.Studentski_dom dom in _domovi)
            {
                DataRow columns = domovi.NewRow();
                columns["ID"] = dom.Id;
                columns["Stevilka doma"] = dom.Stevilka_Doma;
                columns["Ime doma"] = dom.Ime;
                

                domovi.Rows.Add(columns);
            }

            griddomovi.ItemsSource = domovi.DefaultView;

        }
        public Dodatne()
        {
            InitializeComponent();
            dodatne1 = this;

            try
            {
                NapolniTabeloDomov();
                NapolniTabeloStudentov();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void btndodajstudenta_Click(object sender, RoutedEventArgs e)
        {
            DodajStudenta dodaj = new DodajStudenta();
            dodaj.Show();
            this.Close();
        }

        private void btnnazaj_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnodstrani_Click(object sender, RoutedEventArgs e)
        {
            OdstraniStudenta odstranis = new OdstraniStudenta();
            odstranis.Show();
            this.Close();
        }

        private void btnodstranidom_Click(object sender, RoutedEventArgs e)
        {
            OdstraniDom odstranid = new OdstraniDom();
            odstranid.Show();
            this.Close();
        }

        private void btnuredistudenta_Click(object sender, RoutedEventArgs e)
        {
            UrediStudenta uredi = new UrediStudenta();
            uredi.Show();
            this.Close();
        }

        private void btnuredidom_Click(object sender, RoutedEventArgs e)
        {
            UrediDom uredi1 = new UrediDom();
            uredi1.Show();
            this.Close();
        }

        private void btndodajdom_Click(object sender, RoutedEventArgs e)
        {
            DodajDom dodaj11 = new DodajDom();
            dodaj11.Show();
            this.Close();
        }
    }
}
