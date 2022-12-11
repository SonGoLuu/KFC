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
    public class BUS_ChiTietPhieuNhap
    {
        DAL_ChiTietPhieuNhap c = new DAL_ChiTietPhieuNhap();
        public DataTable getCTPN(string maphieu)
        {
            return c.getCTPN(maphieu);
        }
        public DataTable getPN(string maphieu)
        {
            return c.getPN(maphieu);
        }
        public bool themCTPN(DTO_CTPN ctpn)
        {
            return c.themCTPN(ctpn);
        }    

    }
}
