using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace naloga_6
{
    public partial class OdstraniStudenta : System.Web.UI.Page
    {
        ServiceReference1.StoritveSoapClient StudentskiDomovi = new ServiceReference1.StoritveSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool uspesnost = false;
            int id = int.Parse(TextBox1.Text);


            if (id.ToString() != "")
            {
                uspesnost = StudentskiDomovi.OdstraniStudenta(id);
            }
            if (uspesnost == true)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Uspešno odstranjen!');", true);
                TextBox1.Text = "";

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Prišlo je do napake!');", true);
                TextBox1.Text = "";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DodatneOpcije.aspx");
        }
    }
}