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
    /// Interaction logic for OdstraniDom.xaml
    /// </summary>
    public partial class OdstraniDom : Window
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
        OdstraniDom odstrani1;
        public OdstraniDom()
        {
            InitializeComponent();
            odstrani1 = this;
            try
            {

                NapolniTabeloDomov();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnpotrdi_Click(object sender, RoutedEventArgs e)
        {
            grid.Visibility = Visibility.Hidden;
            bool uspesnost = false;
            int id = int.Parse(txt.Text);


            if (id.ToString() != "")
            {
                uspesnost = StudentskiDomovi.OdstraniDom(id);
            }
            if (uspesnost == true)
            {
                MessageBox.Show("Uspešno");
                txt.Text = "";

            }
            else
            {
                MessageBox.Show("Napaka");
                txt.Text = "";

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
