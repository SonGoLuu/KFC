using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_BangKeLuong
    {
        int _ID;
        string _MaNV;
        int _NghiPhep;
        float _LuongNhan;
        DateTime _Thoigian;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

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

        public int NghiPhep
        {
            get
            {
                return _NghiPhep;
            }
            set
            {
                _NghiPhep = value;
            }
        }

        public float LuongNhan
        {
            get
            {
                return _LuongNhan;
            }
            set
            {
                _LuongNhan = value;
            }
        }

        public DateTime Thoigian
        {
            get
            {
                return _Thoigian;
            }
            set
            {
                _Thoigian = value;
            }
        }

        public DTO_BangKeLuong() { }

        public DTO_BangKeLuong(int id, string manv, int nghiphep, float luongnhan, DateTime thoigian)
        {
            this.ID = id;
            this.MaNV = manv;
            this.NghiPhep = nghiphep;
            this.LuongNhan = luongnhan;
            this.Thoigian = thoigian;
        }

        //Thêm bảng kê lương ko có ID
        public DTO_BangKeLuong(string manv, int nghiphep, float luongnhan, DateTime thoigian)
        {
            this.MaNV = manv;
            this.NghiPhep = nghiphep;
            this.LuongNhan = luongnhan;
            this.Thoigian = thoigian;
        }
    }
}
