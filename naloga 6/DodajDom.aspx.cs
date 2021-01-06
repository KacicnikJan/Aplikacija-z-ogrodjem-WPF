using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace naloga_6
{
    public partial class DodajDom : System.Web.UI.Page
    {
        ServiceReference1.StoritveSoapClient StudentskiDomovi = new ServiceReference1.StoritveSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_potrdi_Click(object sender, EventArgs e)
        {
            bool uspesnost = false;
            string ime = textime.Text;
            int stevilka = int.Parse(textstevilka.Text);
            int letonastanka = int.Parse(textletonastanka.Text);


            ServiceReference1.Studentski_dom dom = new ServiceReference1.Studentski_dom();

            dom.Stevilka_Doma = stevilka;
            dom.Ime = ime;
            dom.Leto_Nastanka = letonastanka;


            if (stevilka.ToString() != "" && ime != ""  && letonastanka.ToString() != "")
            {
                uspesnost = StudentskiDomovi.DodajStudentskiDom(dom);
            }
            if (uspesnost == true)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Uspešno dodano!');", true);
                
                textstevilka.Text = "";
                textime.Text = "";
                textletonastanka.Text = "";

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Prišlo je do napake!');", true);
                
                textstevilka.Text = "";
                textime.Text = "";
                textletonastanka.Text = "";

            }
        }

        protected void button_nazaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DodatneOpcije.aspx");
        }
    }
}