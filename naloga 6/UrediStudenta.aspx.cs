using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace naloga_6
{
    public partial class UrediStudenta : System.Web.UI.Page
    {
        ServiceReference1.StoritveSoapClient StudentskiDomovi = new ServiceReference1.StoritveSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_uredi_Click(object sender, EventArgs e)
        {
            bool uspesnost = false;
            int id = int.Parse(TextBox1.Text);
            int emso = int.Parse(TextBox2.Text);
            string ime = TextBox3.Text;
            string priimek = TextBox4.Text;
            int letoRojstva = int.Parse(TextBox5.Text);



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
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Uspešno dodano!');", true);
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";


            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Prišlo je do napake!');", true);
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DodatneOpcije.aspx");
        }
    }
}