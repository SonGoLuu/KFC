using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_CTHD
    {
        string _MaHD;
        string _MaTD;
        int _SLMua;
        float _ThanhTien;

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

        public int SLMua
        {
            get
            {
                return _SLMua;
            }
            set
            {
                _SLMua = value;
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

        public DTO_CTHD() { }

        public DTO_CTHD(string mahd, string matd, int slmua, float thanhtien)
        {
            this.MaHD = mahd;
            this.MaTD = matd;
            this.SLMua = slmua;
            this.ThanhTien = thanhtien;
        }
    }
}
