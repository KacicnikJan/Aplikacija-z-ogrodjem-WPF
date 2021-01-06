using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace naloga_6
{
    public partial class DodatneOpcije : System.Web.UI.Page
    {
        ServiceReference1.StoritveSoapClient StudentskiDomovi = new ServiceReference1.StoritveSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.VstaviStudente();
            this.VstaviDom();
        }

        protected void VstaviStudente()
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("id"), new DataColumn("emso"), new DataColumn("ime"), new DataColumn("priimek"), new DataColumn("letnicaRojstva") });

            foreach (var item in StudentskiDomovi.PridobiVseStudente())
            {
                dr = dt.NewRow();
                dr["id"] = item.Id.ToString();
                dr["emso"] = item.Emso.ToString();
                dr["ime"] = item.Ime.ToString();
                dr["priimek"] = item.Priimek.ToString();
                dr["letnicaRojstva"] = item.LetoRojstva.ToString();
                
                dt.Rows.Add(dr);

            }

            ViewState["dt"] = dt;
            this.BindGridStudent();

        }

        protected void BindGridStudent()
        {
            gridViewStudent.DataSource = ViewState["dt"] as DataTable;
            gridViewStudent.DataBind();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            gridViewStudent.EditIndex = e.NewEditIndex;
            this.BindGridStudent();
        }

        protected void gridViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void VstaviDom()
        {
            DataTable dti = new DataTable();
            DataRow dr = null;
            dti.Columns.AddRange(new DataColumn[3] { new DataColumn("id"), new DataColumn("stevilkaDoma"), new DataColumn("imedoma") });

            foreach (var item in StudentskiDomovi.PridobiVseDomove())
            {
                dr = dti.NewRow();
                dr["id"] = item.Id.ToString();
                dr["stevilkadoma"] = item.Stevilka_Doma.ToString();
                dr["imedoma"] = item.Ime.ToString();
                
                dti.Rows.Add(dr);

            }

            ViewState["dti"] = dti;
            this.BindGridDomovi();

        }
        protected void BindGridDomovi()
        {
            gridViewDom.DataSource = ViewState["dti"] as DataTable;
            gridViewDom.DataBind();
        }

        protected void OnRowEditingDom(object sender, GridViewEditEventArgs e)
        {
            gridViewDom.EditIndex = e.NewEditIndex;
            this.BindGridDomovi();
        }

        protected void OnCancelDom(object sender, EventArgs e)
        {
            gridViewDom.EditIndex = -1;
            this.BindGridDomovi();
        }



        protected void button_dodajstudenta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DodajStudenta.aspx");
        }

        protected void button_dodajdom_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DodajDom.aspx");
        }

        protected void button_dodajstudentavdom_Click(object sender, EventArgs e)
        {

        }

        protected void button_odstranistudenta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/OdstraniStudentaIzDoma.aspx");
        }

        protected void button_nazaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }

        

        protected void Odstrani_studenta(object sender, EventArgs e)
        {
            Response.Redirect("~/OdstraniStudenta.aspx");
        }

        protected void Unnamed2_Click1(object sender, EventArgs e)
        {

        }

       
        protected void gridViewDom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnOdstraniDom_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/OdstraniDom.aspx");
        }

        protected void btn_uredi_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UrediStudenta.aspx");
        }

        protected void btn_uredidoma_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UrediDom.aspx");
        }
    }
}