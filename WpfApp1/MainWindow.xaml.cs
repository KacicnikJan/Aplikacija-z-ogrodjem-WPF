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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ServiceReference1.Service1Client StudentskiDomovi = new ServiceReference1.Service1Client();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnprijava_Click(object sender, RoutedEventArgs e)
        {
            bool jeAdmin = StudentskiDomovi.vpis(upimetxt.Text, geslotxt.Text);
            if (jeAdmin == true)
            {
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            else
            {
                Navaden navaden = new Navaden();
                navaden.Show();
                this.Close();
            }

        }

        private void btnizhod_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
