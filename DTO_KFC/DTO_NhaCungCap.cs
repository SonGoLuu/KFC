using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_NhaCungCap
    {
        string _MaNCC;
        string _TenNCC;

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

        public string TenNCC
        {
            get
            {
                return _TenNCC;
            }
            set
            {
                _TenNCC = value;
            }
        }

        public DTO_NhaCungCap() { }

        public DTO_NhaCungCap(string manncc, string tenncc)
        {
            this.MaNCC = manncc;
            this.TenNCC = tenncc;
        }
    }
}
