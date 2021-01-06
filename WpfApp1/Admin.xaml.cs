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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        ServiceReference1.Service1Client StudentskiDomovi = new ServiceReference1.Service1Client();

        public static Admin Admin1;

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
                DataRow studentek = studentje.NewRow();
                studentek["ID"] = student.Id;
                studentek["Ime"] = student.Ime;
                studentek["Priimek"] = student.Priimek;
                studentek["Leto rojstva"] = student.LetoRojstva;
                studentek["EMSO"] = student.Emso;

                studentje.Rows.Add(studentek);
            }

            studentjeGrid.ItemsSource = studentje.DefaultView;

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
                DataRow domek = domovi.NewRow();
                domek["ID"] = dom.Id;
                domek["Stevilka doma"] = dom.Stevilka_Doma;
                domek["Ime doma"] = dom.Ime;
                

                domovi.Rows.Add(domek);
            }

            domoviGrid.ItemsSource = domovi.DefaultView;

        }

        public Admin()
        {
            InitializeComponent();
            Admin1 = this;

            try
            {
                NapolniTabeloDomov();
                NapolniTabeloStudentov();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            domoviGrid.Visibility = Visibility.Hidden;
            studentjeGrid.Visibility = Visibility.Hidden;
        }

        private void btnizpisdomaznajvecstudenti_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(StudentskiDomovi.VrniDom().Ime.ToString(), "Dom z najvec");
        }

        private void btnizpisinformacijonajstarejsemstudentu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<ServiceReference1.Student> listStudent = new List<ServiceReference1.Student>();
                listStudent.Add(StudentskiDomovi.IzpisNajstarejsega());



                domoviGrid.Visibility = Visibility.Hidden;
                studentjeGrid.Visibility = Visibility.Visible;

                studentjeGrid.ItemsSource = listStudent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Napaka");
            }


        }

        private void btnpovprecnoleto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(StudentskiDomovi.IzpisPovprecneStarosti().ToString(), "Povprecna starost");
        }

        private void btnizpisvsehdomov_Click(object sender, RoutedEventArgs e)
        {
            domoviGrid.Visibility = Visibility.Visible;
            NapolniTabeloDomov();
        }

        private void btnizpisvsehstudentov_Click(object sender, RoutedEventArgs e)
        {
            studentjeGrid.Visibility = Visibility.Visible;
            NapolniTabeloStudentov();
        }

        private void btndodatne_Click(object sender, RoutedEventArgs e)
        {
            Dodatne dodatne = new Dodatne();
            dodatne.Show();
            this.Close();
        }

        private void btnzapri_Click(object sender, RoutedEventArgs e)
        {
            domoviGrid.Visibility = Visibility.Hidden;
            studentjeGrid.Visibility = Visibility.Hidden;


        }

        private void btnizpisinformacijostudentu_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<ServiceReference1.Student> listStudent = new List<ServiceReference1.Student>();
                listStudent.Add(StudentskiDomovi.VrniStudenta(int.Parse(txtbox3.Text)));
                
                domoviGrid.Visibility = Visibility.Hidden;
                studentjeGrid.Visibility = Visibility.Visible;
                btnzapri.Visibility = Visibility.Visible;
                if (txtbox3.Text != "")
                {
                    studentjeGrid.ItemsSource = listStudent;
                }
                else
                {
                    MessageBox.Show("Vnesite emso!", "Napaka");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Vnesite emso", "Napaka");
            }
            txtbox2.Clear();
        }
    }
}
