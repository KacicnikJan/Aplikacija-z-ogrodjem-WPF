using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace naloga_6
{
    public partial class UrediDom : System.Web.UI.Page
    {
        ServiceReference1.StoritveSoapClient StudentskiDomovi = new ServiceReference1.StoritveSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_uredidom_Click(object sender, EventArgs e)
        {
            bool uspesnost = false;
            int id = int.Parse(TextBox1.Text);
            int stevilka = int.Parse(TextBox2.Text);
            string ime = TextBox3.Text;
            
            ServiceReference1.Studentski_dom dom = new ServiceReference1.Studentski_dom();

            dom.Id = id;
            dom.Stevilka_Doma = stevilka;
            dom.Ime = ime;        
            if (id.ToString() != "" && stevilka.ToString() != "" && ime != "" )
            {
                uspesnost = StudentskiDomovi.UrediDom(dom.Id, dom.Ime, dom.Stevilka_Doma);
            }
            if (uspesnost == true)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Uspešno dodano!');", true);
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Prišlo je do napake!');", true);
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";               
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DodatneOpcije.aspx");
        }
    }
}