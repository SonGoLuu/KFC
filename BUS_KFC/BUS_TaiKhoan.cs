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
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan t = new DAL_TaiKhoan();
        public bool checkTaiKhoan(string TenTaiKhoan, string MatKhau)
        {
            return t.checkTaiKhoan(TenTaiKhoan, MatKhau);
        }
        public DataTable getAllTaiKhoan()
        {
            return t.getAllTaiKhoan();
        }
        public DataTable getCBBNV()
        {
            return t.getCBBNV();
        }
        public DataTable getAllCBBNV()
        {
            return t.getAllCBBNV();
        }
        public string getMaNV(string tentaikhoan)
        {
            return t.getMaNV(tentaikhoan);
        }
        public string getTenTaiKhoan(string manv)
        {
            return t.getTenTaiKhoan(manv);
        }    
        public string getMatKhau(string tentaikhoan)
        {
            return t.getMatKhau(tentaikhoan);
        }
        public bool themTaiKhoan(string TenTaiKhoan, string MatKhau, string MaNV)
        {
            return t.themTaiKhoan(TenTaiKhoan, MatKhau, MaNV);
        }
        public bool suaTaiKhoan(string TenTaiKhoan, string MatKhau)
        {
            return t.suaTaiKhoan(TenTaiKhoan, MatKhau);
        }
        public bool xoaTaiKhoan(string TenTaiKhoan)
        {
            return t.xoaTaiKhoan(TenTaiKhoan);
        }
    }
}
