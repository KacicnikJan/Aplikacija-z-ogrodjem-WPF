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
    /// Interaction logic for UrediDom.xaml
    /// </summary>
    public partial class UrediDom : Window
    {
        ServiceReference1.Service1Client StudentskiDomovi = new ServiceReference1.Service1Client();
        ServiceReference1.Studentski_dom dom = new ServiceReference1.Studentski_dom();


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

            grid.ItemsSource = domovi.DefaultView;

        }
        UrediDom uredi1;
        public UrediDom()
        {
            InitializeComponent();
            uredi1 = this;
            try
            {

                NapolniTabeloDomov();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnuredi_Click(object sender, RoutedEventArgs e)
        {
            grid.Visibility = Visibility.Hidden;
            bool uspesnost = false;
            int id = int.Parse(txt1.Text);
            int stevilka = int.Parse(txt2.Text);
            string ime = txt3.Text;

            ServiceReference1.Studentski_dom dom = new ServiceReference1.Studentski_dom();

            dom.Id = id;
            dom.Stevilka_Doma = stevilka;
            dom.Ime = ime;
            if (id.ToString() != "" && stevilka.ToString() != "" && ime != "")
            {
                uspesnost = StudentskiDomovi.UrediDom(dom.Id, dom.Ime, dom.Stevilka_Doma);
            }
            if (uspesnost == true)
            {
                MessageBox.Show("Uspešno");
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
            }
            else
            {
                MessageBox.Show("Napaka");
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
            }
            grid.Visibility = Visibility.Visible;
            NapolniTabeloDomov();
        }

        private void btnnazaj_Click(object sender, RoutedEventArgs e)
        {
            Dodatne dodatne = new Dodatne();
            dodatne.Show();
            this.Close();
        }
    }
}
