using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace naloga_6
{
    public partial class Admin : System.Web.UI.Page
    {

        

        ServiceReference1.StoritveSoapClient StudentskiDomovi = new ServiceReference1.StoritveSoapClient();

        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void button_izpisvsehstudentov_Click(object sender, EventArgs e)
        {          
            GridView1.DataSource = StudentskiDomovi.PridobiVseStudente();
            GridView1.DataBind();
        }

        

        protected void button_izpisvsehdomov_Click(object sender, EventArgs e)
        {
            SeznamDomov.DataSource = StudentskiDomovi.PridobiVseDomove();
            SeznamDomov.DataBind();
        }

        protected void button_izpisdomaznajvecstudenti_Click(object sender, EventArgs e)
        {
            var dom = StudentskiDomovi.VrniDom();
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Dom z največ:   id:"  + dom.Id.ToString()+ ", leto: " + dom.Leto_Nastanka.ToString()  + "');", true);
        }

        protected void button_izpisinformacijonajstarejsemstudentu_Click(object sender, EventArgs e)
        {
            var student = StudentskiDomovi.IzpisNajstarejsega();
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Najstarejša oseba: id: " + student.Id.ToString() + ", emso: " + student.Emso.ToString() + ", ime: " + student.Ime + ", priimek: " + student.Priimek + ", leto rojstva: " + student.LetoRojstva.ToString() + "');", true);
        }

        protected void button_izpispovprecnestarostistudentov_Click(object sender, EventArgs e)
        {
            var student = StudentskiDomovi.IzpisPovprecneStarosti();
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Povprecna rojstno leto: " +student + "');", true);
        }

        protected void button_izpisstudentovvdomu_Click(object sender, EventArgs e)
        {           
            var student = StudentskiDomovi.PridobiVseStudenteVDomu(int.Parse(TextBox1.Text));
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Podrobnosti studenta: id: " + student+ "');", true);
        }

        protected void button_izpisdomastudenta_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = StudentskiDomovi.PridobiVseStudenteVDomu(int.Parse(TextBox2.Text));
            GridView1.DataBind();
        }

        protected void button_izpisinformacijostudentu_Click(object sender, EventArgs e)
        {
            var student = StudentskiDomovi.VrniStudenta(int.Parse(txtInformacijeStudent.Text));
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Podrobnosti studenta: id: " + student.Id.ToString() + ", emso: " + student.Emso.ToString() + ", ime: " + student.Ime.ToString() + ", priimek: " + student.Priimek.ToString() + ", leto rojstva: " + student.LetoRojstva.ToString() +   "');", true);
        }

        protected void button_dodatneopcije_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DodatneOpcije.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Vpis.aspx");
        }
    }
}