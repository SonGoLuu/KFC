using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_HoaDon
    {
        string _MaHD;
        string _TenKH;
        string _MaNVLap;
        DateTime _Ngaylap;
        float _TongTien;

        public string MaHD
        {
            get
            {
                return _MaHD;
            }
            set
            {
                _MaHD = value;
            }
        }

        public string TenKH
        {
            get
            {
                return _TenKH;
            }
            set
            {
                _TenKH = value;
            }
        }

        public string MaNVLap
        {
            get
            {
                return _MaNVLap;
            }
            set
            {
                _MaNVLap = value;
            }
        }

        public DateTime NgayLap
        {
            get
            {
                return _Ngaylap;
            }
            set
            {
                _Ngaylap = value;
            }
        }

        public float TongTien
        {
            get
            {
                return _TongTien;
            }
            set
            {
                _TongTien = value;
            }
        }

        public DTO_HoaDon() { }

        public DTO_HoaDon(string mahd, string tenkh, string manvlap, DateTime ngaylap, float tongtien)
        {
            this.MaHD = mahd;
            this.TenKH = tenkh;
            this.MaNVLap = manvlap;
            this.NgayLap = ngaylap;
            this.TongTien = tongtien;
        }
    }
}
