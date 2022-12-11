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
    public class BUS_ChiTietHoaDon
    {
        DAL_ChiTietHoaDon cthd = new DAL_ChiTietHoaDon();
        public DataTable getAllThucDon()
        {
            return cthd.getAllThucDon();
        }
        public DataTable getTheoTungNhomThucDon(string manhom)
        {
            return cthd.getTheoTungNhomThucDon(manhom);
        }
        public string getMaNhom(string tennhom)
        {
            return cthd.getMaNhom(tennhom);
        }
        public bool themCTHD(DTO_CTHD chitiethoadon)
        {
            return cthd.themCTHD(chitiethoadon);
        }
    }
}
