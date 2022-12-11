using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_PhieuNhap
    {
        string _MaPhieu;
        string _MaNV;
        string _MaNCC;
        DateTime _NgayLap;
        float _TongTien;

        public string MaPhieu
        {
            get
            {
                return _MaPhieu;
            }
            set
            {
                _MaPhieu = value;
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

        public string MaNCC
        {
            get
            {
                return _MaNCC;
            }
            set
            {
                _MaNCC = value;
            }
        }

        public DateTime NgayLap
        {
            get
            {
                return _NgayLap;
            }
            set
            {
                _NgayLap = value;
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

        public DTO_PhieuNhap() { }

        public DTO_PhieuNhap(string maphieu, string manv, string mancc, DateTime ngaylap, float tongtien)
        {
            this.MaPhieu = maphieu;
            this.MaNV = manv;
            this.MaNCC = mancc;
            this.NgayLap = ngaylap;
            this.TongTien = tongtien;
        }
    }
}
