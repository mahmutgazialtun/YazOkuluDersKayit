using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluDersKayıt
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDers> EntDers = BLLDers.BllDersListele();
                DropDownList1.DataSource = BLLDers.BllDersListele();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BASOGRID = int.Parse(TextBox1.Text);
            ent.BASDERSID = int.Parse(DropDownList1.SelectedValue.ToString());

            BLLDers.BllTalepEkle(ent);
        }
    }
}