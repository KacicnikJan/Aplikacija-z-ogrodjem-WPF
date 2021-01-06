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
    /// Interaction logic for UrediStudenta.xaml
    /// </summary>
    public partial class UrediStudenta : Window
    {
        ServiceReference1.Service1Client StudentskiDomovi = new ServiceReference1.Service1Client();
        ServiceReference1.Student student = new ServiceReference1.Student();

        UrediStudenta uredi1;
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
                DataRow uporabnikVrstica = studentje.NewRow();
                uporabnikVrstica["ID"] = student.Id;
                uporabnikVrstica["Ime"] = student.Ime;
                uporabnikVrstica["Priimek"] = student.Priimek;
                uporabnikVrstica["Leto rojstva"] = student.LetoRojstva;
                uporabnikVrstica["EMSO"] = student.Emso;

                studentje.Rows.Add(uporabnikVrstica);
            }

            grid.ItemsSource = studentje.DefaultView;

        }



        public UrediStudenta()
        {
            InitializeComponent();
            uredi1 = this;
            try
            {
                
                NapolniTabeloStudentov();
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
                uspesnost = StudentskiDomovi.UrediStudenta(student.Id, student.Emso, student.Ime, student.Priimek, student.LetoRojstva);
            }
            if (uspesnost == true)
            {
                MessageBox.Show("Uspešno");
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
            grid.Visibility = Visibility.Visible;
            NapolniTabeloStudentov();
        }

        private void btnnazaj_Click(object sender, RoutedEventArgs e)
        {
            Dodatne dodatne = new Dodatne();
            dodatne.Show();
            this.Close();
        }

        private void btnurejanje_Click(object sender, RoutedEventArgs e)
        {
            /*try
            {
                if (btnurejanje.Content.ToString() == "Omogoči urejanje osebe")
                {
                    if (grid.SelectedItems.Count > 0 && txt2.Text != "")
                    {
                        
                        btnurejanje.Content = "Končaj urejanje";
                    }
                    else
                    {
                        MessageBox.Show("Izberite osebo!", "Napaka");
                    }

                }
                else
                {
                    student.Id = int.Parse(txt1.Text);
                    student.Emso = int.Parse(txt2.Text);
                    student.Ime = txt3.Text;
                    student.Priimek = txt4.Text;
                    student.LetoRojstva = int.Parse(txt5.Text);
                    
                    ServiceReference1.Student studentek = new ServiceReference1.Student();
                    studentek = (ServiceReference1.Student)grid.SelectedItem;
                    bool jeUrejeno = StudentskiDomovi.UrediStudenta(studentek.Id, studentek.Emso, studentek.Ime, studentek.Priimek, studentek.LetoRojstva);
                    grid.ItemsSource = StudentskiDomovi.PridobiVseStudente();

                    btnurejanje.Content = "Omogoči urejanje osebe";
                    btnuredi.IsEnabled = true;

                    txt1.Clear();
                    txt2.Clear();
                    txt3.Clear();
                    txt4.Clear();
                    txt5.Clear();
                    
                    grid.IsEnabled = true;
                    if (jeUrejeno)
                    {
                        MessageBox.Show("Urejanje končano", "Uspešno posodobljeno");
                    }
                    else
                    {
                        MessageBox.Show("Urejanje ni uspelo", "Napaka");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Napaka");
            }*/
        }
    }
}
