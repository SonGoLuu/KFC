using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_ThucDon
    {
        string _MaTD;
        string _TenTD;
        string _MaNhom;
        string _ChiTiet;
        float _GiaBan;
        int _GiamGia;

        public string MaTD
        {
            get
            {
                return _MaTD;
            }
            set
            {
                _MaTD = value;
            }
        }
        public string TenTD
        {
            get
            {
                return _TenTD;
            }
            set
            {
                _TenTD = value;
            }
        }

        public string MaNhom
        {
            get
            {
                return _MaNhom;
            }
            set
            {
                _MaNhom = value;
            }
        }

        public float GiaBan
        {
            get
            {
                return _GiaBan;
            }
            set
            {
                _GiaBan = value;
            }
        }

        public string ChiTiet
        {
            get
            {
                return _ChiTiet;
            }
            set
            {
                _ChiTiet = value;
            }
        }

        public int GiamGia
        {
            get
            {
                return _GiamGia;
            }
            set
            {
                _GiamGia = value;
            }
        }

        public DTO_ThucDon() { }

        public DTO_ThucDon(string matd, string tentd, string manhom, float giaban, string chitiet, int giamgia)
        {
            this.MaTD = matd;
            this.TenTD = tentd;
            this.MaNhom = manhom;
            this.GiaBan = giaban;
            this.ChiTiet = chitiet;
            this.GiamGia = giamgia;
        }
    }
}
