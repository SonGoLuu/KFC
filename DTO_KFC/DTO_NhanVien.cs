using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_NhanVien
    {
        string _MaNV;
        string _HoTenNV;
        string _MaCD;
        DateTime _NgaySinh;
        string _CMND;
        string _DiaChi;
        string _Email;
        string _SDTNV;
        string _GioiTinh;

        public string MaNV
        {
            get
            {
                return _MaNV;
            }
            set
            {
                _MaNV = value;
            }
        }

        public string HoTenNV
        {
            get
            {
                return _HoTenNV;
            }
            set
            {
                _HoTenNV = value;
            }
        }

        public string MaCD
        {
            get
            {
                return _MaCD;
            }
            set
            {
                _MaCD = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }
            set
            {
                _NgaySinh = value;
            }
        }

        public string CMND
        {
            get
            {
                return _CMND;
            }
            set
            {
                _CMND = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }
            set
            {
                _DiaChi = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public string SDTNV
        {
            get
            {
                return _SDTNV;
            }
            set
            {
                _SDTNV = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _GioiTinh;
            }
            set
            {
                _GioiTinh = value;
            }
        }

        public DTO_NhanVien() { }

        public DTO_NhanVien(string manv, string hoten, DateTime ngaysinh, string cmnd, string diachi, string email, string sdtnv, string gioitinh)
        {
            this.MaNV = manv;
            this.HoTenNV = hoten;
            this.NgaySinh = ngaysinh;
            this.CMND = cmnd;
            this.DiaChi = diachi;
            this.Email = email;
            this.SDTNV = sdtnv;
            this.GioiTinh = gioitinh;
        }
        public DTO_NhanVien(string manv, string macd)
        {
            this.MaNV = manv;
            this.MaCD = macd;
        }
    }
}
