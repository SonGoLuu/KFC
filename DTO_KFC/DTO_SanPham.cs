using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_SanPham
    {
        string _MaSP;
        string _TenSP;
        string _Loai;
        int _SLTon;

        public string MaSp
        {
            get
            {
                return _MaSP;
            }
            set
            {
                _MaSP = value;
            }
        }
        public string TenSP
        {
            get
            {
                return _TenSP;
            }
            set
            {
                _TenSP = value;
            }
        }

        public string Loai
        {
            get
            {
                return _Loai;
            }
            set
            {
                _Loai = value;
            }
        }
        public int SLTon
        {
            get
            {
                return _SLTon;
            }
            set
            {
                _SLTon = value;
            }
        }

        
        public DTO_SanPham() { }

        public DTO_SanPham(string masp, string tensp, string loai, int slton)
        {
            this.MaSp = masp;
            this.TenSP = tensp;
            this.Loai = loai;
            this.SLTon = slton;
        }
    }
}
