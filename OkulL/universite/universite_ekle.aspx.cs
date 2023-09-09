using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulL.universite
{
    public partial class universite_ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            okulTableAdapters.universiteTableAdapter univ = new okulTableAdapters.universiteTableAdapter();
            univ.UniversiteEkle(txtUniversiteAdi.Text);
            Response.Redirect("/universite/universite_listesi.aspx");
        }
    }
}