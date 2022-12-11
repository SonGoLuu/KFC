using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_LuongChucDanh
    {
        string _MaCD;
        float _TienLuong;
        float _PhuCap;

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

        public float TienLuong
        {
            get
            {
                return _TienLuong;
            }
            set
            {
                _TienLuong = value;
            }
        }

        public float PhuCap
        {
            get
            {
                return _PhuCap;
            }
            set
            {
                _PhuCap = value;
            }
        }

        public DTO_LuongChucDanh() { }

        public DTO_LuongChucDanh(string macd, float tienluong, float phucap)
        {
            this.MaCD = macd;
            this.TienLuong = tienluong;
            this.PhuCap = phucap;
        }
    }
}
