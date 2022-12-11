using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_KFC;
using DAL_KFC;

namespace BUS_KFC
{
    public class BUS_HoaDon
    {
        DAL_HoaDon h = new DAL_HoaDon();
        public string getMaHDCuoi()
        {
            return h.getMaHDCuoi();
        }
        public DataTable getAllHoaDon()
        {
            return h.getAllHoaDon();
        }
        public DataTable find(string tennv)
        {
            return h.find(tennv);
        }
        public bool themHoaDon(DTO_HoaDon hd)
        {
            return h.themHoaDon(hd);
        }
    }
}
