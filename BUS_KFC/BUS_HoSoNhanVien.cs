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
    public class BUS_HoSoNhanVien
    {
        DAL_HoSoNhanVien h = new DAL_HoSoNhanVien();
        public DataTable getAllHSNV()
        {
            return h.getAllHSNV();
        }
        public string getFileAnh(string manv)
        {
            return h.getFileAnh(manv);
        }
        public DataTable getTenvaCD(string manv)
        {
            return h.getTenvaCD(manv);
        }
        public DataTable getcbbTenNV()
        {
            return h.getcbbTenNV();
        }
        public DataTable getcbbTenNVChuaCo()
        {
            return h.getcbbTenNVChuaCo();
        }
        public DataTable getMotHSNV(string manv)
        {
            return h.getMotHSNV(manv);
        }
        public bool themHSNV(DTO_HoSoNhanVien hsnv)
        {
            return h.themHSNV(hsnv);
        }
        public bool suaHSNV(DTO_HoSoNhanVien hsnv)
        {
            return h.suaHSNV(hsnv);
        }
        public bool xoaHSNV(string manv)
        {
            return h.xoaHSNV(manv);
        }
    }
}
