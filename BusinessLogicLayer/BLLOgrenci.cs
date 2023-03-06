using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int BLLOgrenciEkle(EntityOgrenci p)
        {
            if (p.AD != null && p.SOYAD != null && p.NUMARA != null && p.SIFRE != null && p.FOTOGRAF != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }

        public static List<EntityOgrenci> BllOgrenciListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool BllOgrenciSil(int p)
        {
            if (p >0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> BllOgrenciDetay(int p)
        {
            return DALOgrenci.OgrenciDetay(p);
        }

        public static bool BllOgrenciGuncelle(EntityOgrenci p)
        {
            if (p.AD != null && p.AD!="" && p.SOYAD != null && p.SOYAD != "" && p.NUMARA != null && p.NUMARA != "" && p.SIFRE != null && p.SIFRE != "" && p.FOTOGRAF != null && p.FOTOGRAF != "" && p.ID >0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            else
            {
                return false;
            }
        }
    }
}
