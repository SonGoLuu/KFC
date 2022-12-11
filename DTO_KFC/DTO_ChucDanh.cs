using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_ChucDanh
    {
        string _MaCD;
        string _TenCD;

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

        public string TenCD
        {
            get
            {
                return _TenCD;
            }
            set
            {
                _TenCD = value;
            }
        }

        public DTO_ChucDanh() { }

        public DTO_ChucDanh(string macd, string tencd)
        {
            this.MaCD = macd;
            this.TenCD = tencd;
        }
    }
}
