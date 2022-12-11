using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_PhanQuyen
    {
        string _TenTaiKhoan;
        string _TenQuyen;
        string _ChiTietQuyen;

        public string TenTaiKhoan
        {
            get
            {
                return _TenTaiKhoan;
            }
            set
            {
                _TenTaiKhoan = value;
            }
        }

        public string TenQuyen
        {
            get
            {
                return _TenQuyen;
            }
            set
            {
                _TenQuyen = value;
            }
        }

        public string ChiTietQuyen
        {
            get
            {
                return _ChiTietQuyen;
            }
            set
            {
                _ChiTietQuyen = value;
            }
        }

        public DTO_PhanQuyen() { }

        public DTO_PhanQuyen(string tentaikhoan, string tenquyen, string chitietquyen)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.TenQuyen = tenquyen;
            this.ChiTietQuyen = chitietquyen;
        }
    }
}
