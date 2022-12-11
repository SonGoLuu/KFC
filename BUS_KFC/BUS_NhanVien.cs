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
    public class BUS_NhanVien
    {
        DAL_NhanVien n = new DAL_NhanVien();
        public string getMaNVCuoi()
        {
            return n.getMaNVCuoi();
        }
        public DataTable getNhanVien()
        {
            return n.getNhanVien();
        }
        public DataTable loadDgvNhanVien()
        {
            return n.loadDgvNhanVien();
        }
        public DataTable findNhanVien(string HoTenNV)
        {
            return n.findNhanVien(HoTenNV);
        }
        public DataTable getMotNhanVien(string MaNV)
        {
            return n.getMotNhanVien(MaNV);
        }
        public string getMaNV(string HoTenNV)
        {
            return n.getMaNV(HoTenNV);
        }
        public string getHoTenNV(string MaNV)
        {
            return n.getHoTenNV(MaNV);
        }
        public bool themNhanVien(DTO_NhanVien nv)
        {
            return n.themNhanVien(nv);
        }
        public bool suaNhanVien(DTO_NhanVien nv)
        {
            return n.suaNhanVien(nv);
        }
        public bool xoaNhanVien(string manv)
        {
            return n.xoaNhanVien(manv);
        }    
    }
}
