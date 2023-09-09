using OkulL.okulTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulL.universite
{
    public partial class fakulte_ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                universitecombo.Items.Clear();
                okulTableAdapters.universiteTableAdapter univ=new okulTableAdapters.universiteTableAdapter();
                universitecombo.Items.Add(new ListItem("üniversite seçiniz...",""));
                universitecombo.AppendDataBoundItems = true;
                universitecombo.DataSource = univ.UniversiteListesiGetir();
                universitecombo.DataTextField = "universite_adi";
                universitecombo.DataValueField = "universite_id";
                universitecombo.DataBind();

            }
            


        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            okulTableAdapters.fakulteTableAdapter fakulte = new okulTableAdapters.fakulteTableAdapter();

            int universiteID = Convert.ToInt32(universitecombo.Selected.Item.Value);

            fakulte.FakulteEkle(txtFakulteAdi.Text,universiteID);
            Response.Redirect("/fakulte/fakulte_listesi.aspx");
        }
    }
}