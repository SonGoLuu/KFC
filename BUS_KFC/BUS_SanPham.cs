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
    public class BUS_SanPham
    {
        DAL_SanPham s = new DAL_SanPham();
        public string getMaSPCuoi()
        {
            return s.getMaSPCuoi();
        }
        public DataTable getAllSanPham(string loai)
        {
            return s.getAllSanPham(loai);
        }
        public DataTable findSP(string tensp, string loai)
        {
            return s.findSP(tensp, loai);
        }
        public bool themSanPham(DTO_SanPham sp)
        {
            return s.themSanPham(sp);
        }
        public bool suaSanPham(DTO_SanPham sp)
        {
            return s.suaSanPham(sp);
        }
        public bool xoaSanPham(string masp)
        {
            return s.xoaSanPham(masp);
        }

    }
}
