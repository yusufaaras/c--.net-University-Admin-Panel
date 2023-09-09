using Azure.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulL.universite
{
    public partial class universite_duzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id= Convert.ToInt32(Request.QueryString["id"].ToString());
                okulTableAdapters.universiteTableAdapter univ=new okulTableAdapters.universiteTableAdapter();
                string universiteAdi= univ.UniversiteGetir(id)[0].universite_adi;
                txtUniversiteAdi.Text = universiteAdi;                
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            okulTableAdapters.universiteTableAdapter univ = new okulTableAdapters.universiteTableAdapter();

            univ.UniversiteGuncelle(txtUniversiteAdi.Text,id);
            Response.Redirect("/universite/universite_listesi.aspx");
        }
    }
}