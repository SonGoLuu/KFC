using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_CTTD
    {
        string _MaTD;
        string _MaSP;
        int _SoLuong;

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
        public string MaSP
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

       
        public int SoLuong
        {
            get
            {
                return _SoLuong;
            }
            set
            {
                _SoLuong = value;
            }
        }

        public DTO_CTTD() { }

        public DTO_CTTD(string matd, string masp, int soluong)
        {
            this.MaTD = matd;
            this.MaSP = masp;
            this.SoLuong = soluong;
        }
    }
}
