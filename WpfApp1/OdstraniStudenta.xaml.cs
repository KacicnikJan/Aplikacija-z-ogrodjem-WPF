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
    /// Interaction logic for OdstraniStudenta.xaml
    /// </summary>
    public partial class OdstraniStudenta : Window
    {
        ServiceReference1.Service1Client StudentskiDomovi = new ServiceReference1.Service1Client();
        ServiceReference1.Student student = new ServiceReference1.Student();

        OdstraniStudenta odstrani1;
        public void NapolniTabeloStudentov()
        {
            ServiceReference1.Service1Client storitev = new ServiceReference1.Service1Client();

            List<ServiceReference1.Student> _studentje = storitev.PridobiVseStudente().ToList();

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

            grid.ItemsSource = studentje.DefaultView;

        }
        public OdstraniStudenta()
        {
            InitializeComponent();
            odstrani1 = this;
            try
            {

                NapolniTabeloStudentov();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnodstrani_Click(object sender, RoutedEventArgs e)
        {
            grid.Visibility = Visibility.Hidden;
            bool uspesnost = false;
            int id = int.Parse(txt.Text);


            if (id.ToString() != "")
            {
                uspesnost = StudentskiDomovi.OdstraniStudenta(id);
            }
            if (uspesnost == true)
            {
                MessageBox.Show("uspešno");
                txt.Text = "";

            }
            else
            {
                MessageBox.Show("Napaka");
                txt.Text = "";

            }
            grid.Visibility = Visibility.Visible;
            NapolniTabeloStudentov();
        }

        private void btnnazaj_Click(object sender, RoutedEventArgs e)
        {
            Dodatne dodatne = new Dodatne();
            dodatne.Show();
            this.Close();
        }
    }
}
