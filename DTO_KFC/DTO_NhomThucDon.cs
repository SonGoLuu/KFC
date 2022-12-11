using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_NhomThucDon
    {
        string _MaNhom;
        string _TenNhom;

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

        public string TenNhom
        {
            get
            {
                return _TenNhom;
            }
            set
            {
                _TenNhom = value;
            }
        }

        public DTO_NhomThucDon() { }

        public DTO_NhomThucDon(string manhom, string tennhom)
        {
            this.MaNhom = manhom;
            this.TenNhom = tennhom;
        }
    }
}
