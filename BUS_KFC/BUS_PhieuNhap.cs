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
    public class BUS_PhieuNhap
    {
        DAL_PhieuNhap p = new DAL_PhieuNhap();
        public string getMaPNCuoi()
        {
            return p.getMaPNCuoi();
        }
        public DataTable getAllPhieuNhap()
        {
            return p.getAllPhieuNhap();
        }
        public DataTable find(string tennv)
        {
            return p.find(tennv);
        }
        public DataTable getCbbNCC()
        {
            return p.getCbbNCC();
        }
        public string getMaNCC(string tenncc)
        {
            return p.getMaNCC(tenncc);
        }
        public DataTable getNguyenLieu(string manl)
        {
            return p.getNguyenLieu(manl);
        }
        public bool checkNguyenLieu(string manl)
        {
            return p.checkNguyenLieu(manl);
        }
        public bool themPhieuNhap(DTO_PhieuNhap pn)
        {
            return p.themPhieuNhap(pn);
        }
    }
}
