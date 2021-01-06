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
    /// Interaction logic for DodajStudenta.xaml
    /// </summary>
    public partial class DodajStudenta : Window
    {
        ServiceReference1.Service1Client StudentskiDomovi = new ServiceReference1.Service1Client();
        public DodajStudenta()
        {
            InitializeComponent();
        }

        private void btnpotrdi_Click(object sender, RoutedEventArgs e)
        {
            bool uspesnost = false;
            int id = int.Parse(txt1.Text);
            int emso = int.Parse(txt2.Text);
            string ime = txt3.Text;
            string priimek = txt4.Text;
            int letoRojstva = int.Parse(txt5.Text);



            ServiceReference1.Student student = new ServiceReference1.Student();

            student.Id = id;
            student.Emso = emso;
            student.Ime = ime;
            student.Priimek = priimek;
            student.LetoRojstva = letoRojstva;


            if (id.ToString() != "" && emso.ToString() != "" && ime != "" && priimek != "" && letoRojstva.ToString() != "")
            {
                uspesnost = StudentskiDomovi.DodajStudenta(student.Id, student.Emso, student.Ime, student.Priimek, student.LetoRojstva);
            }
            if (uspesnost == true)
            {
                MessageBox.Show(" Uspešno!");
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";


            }
            else
            {
                MessageBox.Show("Napaka");
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";


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
