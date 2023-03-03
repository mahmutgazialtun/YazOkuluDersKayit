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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = "Derya";
            ent.SOYAD = "Yıldız";
            ent.NUMARA = "8216";
            ent.SIFRE = "123";
            ent.FOTOGRAF = null;

            BLLOgrenci.BLLOgrenciEkle(ent);
        }
    }
}