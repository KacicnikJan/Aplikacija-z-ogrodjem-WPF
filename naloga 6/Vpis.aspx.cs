using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace naloga_6
{
    public partial class Vpis : System.Web.UI.Page
    {
        ServiceReference1.StoritveSoapClient StudentskiDomovi = new ServiceReference1.StoritveSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_prijava_Click(object sender, EventArgs e)
        {
            bool jeAdmin = StudentskiDomovi.vpis(upime.Text, geslo.Text);
            if (jeAdmin == true)
            {
                Response.Redirect("~/Admin.aspx");
            }
            else
            {
                Response.Redirect("~/NavadenUporabnik.aspx");
            }
        }
    }
}