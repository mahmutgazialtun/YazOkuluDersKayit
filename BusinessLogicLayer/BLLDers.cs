using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllDersListele()
        {
            return DALDers.DersListesi();
        }

        public static int BllTalepEkle(EntityBasvuruForm p)
        {
            if (p.BASOGRID != null && p.BASDERSID != null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;

        }
    }
}
