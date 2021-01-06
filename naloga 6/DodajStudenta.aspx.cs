using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace naloga_6
{
    public partial class DodajŠtudenta : System.Web.UI.Page
    {
        ServiceReference1.StoritveSoapClient StudentskiDomovi = new ServiceReference1.StoritveSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_potrdi_Click(object sender, EventArgs e)
        {
            bool uspesnost = false;
            int id = int.Parse(textid.Text);
            int emso = int.Parse(textemso.Text);
            string ime = textime.Text;
            string priimek = textpriimek.Text;
            int letoRojstva = int.Parse(textletorojstva.Text);
            
            

            ServiceReference1.Student student = new ServiceReference1.Student();

            student.Id = id;
            student.Emso = emso;
            student.Ime = ime;
            student.Priimek = priimek;
            student.LetoRojstva = letoRojstva;
            
            
            if (id.ToString() != "" && emso.ToString() != "" && ime != "" && priimek != "" && letoRojstva.ToString() != ""  )
            {
                uspesnost = StudentskiDomovi.DodajStudenta(student);
            }
            if (uspesnost == true)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Uspešno dodano!');", true);
                textid.Text = "";
                textemso.Text = "";
                textime.Text = "";
                textpriimek.Text = "";
                textletorojstva.Text = "";
               
                
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Prišlo je do napake!');", true);
                textid.Text = "";
                textemso.Text = "";
                textime.Text = "";
                textpriimek.Text = "";
                textletorojstva.Text = "";

               
            }
        }

        protected void button_nazaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DodatneOpcije.aspx");
        }
    }
}