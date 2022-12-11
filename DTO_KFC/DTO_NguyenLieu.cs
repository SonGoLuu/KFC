using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_NguyenLieu
    {
        string _MaNL;
        string _TenNL;
        string _DonVi;
        int _SLTon;

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

        public string TenNL
        {
            get
            {
                return _TenNL;
            }
            set
            {
                _TenNL = value;
            }
        }

        public string DonVi
        {
            get
            {
                return _DonVi;
            }
            set
            {
                _DonVi = value;
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

        public DTO_NguyenLieu() { }

        public DTO_NguyenLieu(string manl, string tennl, string donvi, int slton)
        {
            this.MaNL = manl;
            this.TenNL = tennl;
            this.DonVi = donvi;
            this.SLTon = slton;
        }
    }
}
