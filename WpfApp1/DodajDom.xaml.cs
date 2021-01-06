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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for DodajDom.xaml
    /// </summary>
    public partial class DodajDom : Window
    {
        ServiceReference1.Service1Client StudentskiDomovi = new ServiceReference1.Service1Client();
        public DodajDom()
        {
            InitializeComponent();
        }

        private void btnpotrdi_Click(object sender, RoutedEventArgs e)
        {
            bool uspesnost = false;
            string ime = txt1.Text;
            int stevilka = int.Parse(txt2.Text);
            int letonastanka = int.Parse(txt3.Text);


            ServiceReference1.Studentski_dom dom = new ServiceReference1.Studentski_dom();

            dom.Stevilka_Doma = stevilka;
            dom.Ime = ime;
            dom.Leto_Nastanka = letonastanka;


            if (stevilka.ToString() != "" && ime != "" && letonastanka.ToString() != "")
            {
                uspesnost = StudentskiDomovi.DodajStudentskiDom(dom.Id, dom.Ime, dom.Leto_Nastanka);
            }
            if (uspesnost == true)
            {
                MessageBox.Show(" Uspešno!");

                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";

            }
            else
            {
                MessageBox.Show(" Napaka!");

                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";

            }
        }

        private void btnnazaj_Click(object sender, RoutedEventArgs e)
        {
            Dodatne dodatne = new Dodatne();
            dodatne.Show();
            this.Close();
        }
    }
}
