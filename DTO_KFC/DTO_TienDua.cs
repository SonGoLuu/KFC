using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_TienDua
    {
        string _MaHD;
        float _TienHang;
        float _TienGiam;
        float _KhachDua;
        float _TraLai;

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

        public float TienHang
        {
            get
            {
                return _TienHang;
            }
            set
            {
                _TienHang = value;
            }
        }

        public float GiamGia
        {
            get
            {
                return _TienGiam;
            }
            set
            {
                _TienGiam = value;
            }
        }

        public float KhachDua
        {
            get
            {
                return _KhachDua;
            }
            set
            {
                _KhachDua = value;
            }
        }

        public float TraLai
        {
            get
            {
                return _TraLai;
            }
            set
            {
                _TraLai = value;
            }
        }

        public DTO_TienDua() { }

        public DTO_TienDua(string mahd, float tienhang, float giamgia, float khachdua, float tralai)
        {
            this.MaHD = mahd;
            this.TienHang = tienhang;
            this.GiamGia = giamgia;
            this.KhachDua = khachdua;
            this.TraLai = tralai;
        }
    }
}
