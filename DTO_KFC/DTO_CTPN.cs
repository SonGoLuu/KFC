using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_CTPN
    {
        string _MaPhieu;
        string _MaNL;
        float _GiaTien;
        int _SLNhap;
        float _ThanhTien;

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

        public string MaNL
        {
            get
            {
                return _MaNL;
            }
            set
            {
                _MaNL = value;
            }
        }

        
        public float GiaTien
        {
            get
            {
                return _GiaTien;
            }
            set
            {
                _GiaTien = value;
            }
        }

        public int SLNhap
        {
            get
            {
                return _SLNhap;
            }
            set
            {
                _SLNhap = value;
            }
        }

        public float ThanhTien
        {
            get
            {
                return _ThanhTien;
            }
            set
            {
                _ThanhTien = value;
            }
        }

        public DTO_CTPN() { }

        public DTO_CTPN(string maphieu, string manl, float giatien, int slnhap, float thanhtien)
        {
            this.MaPhieu = maphieu;
            this.MaNL = manl;
            this.GiaTien = giatien;
            this.SLNhap = slnhap;
            this.ThanhTien = thanhtien;
        }
    }
}
