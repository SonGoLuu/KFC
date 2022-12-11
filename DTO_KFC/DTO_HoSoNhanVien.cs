using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class DTO_HoSoNhanVien
    {
        string _MaNV;
        string _DanToc;
        string _TonGiao;
        string _TinhThanh;
        DateTime _NgayVaoLam;
        string _BangCap;
        string _FileAnh;

        public string MaNV
        {
            get
            {
                return _MaNV;
            }
            set
            {
                _MaNV = value;
            }
        }

        public string DanToc
        {
            get
            {
                return _DanToc;
            }
            set
            {
                _DanToc = value;
            }
        }

        public string TonGiao
        {
            get
            {
                return _TonGiao;
            }
            set
            {
                _TonGiao = value;
            }
        }

        public string TinhThanh
        {
            get
            {
                return _TinhThanh;
            }
            set
            {
                _TinhThanh = value;
            }
        }

        public DateTime NgayVaolam
        {
            get
            {
                return _NgayVaoLam;
            }
            set
            {
                _NgayVaoLam = value;
            }
        }

        public string BangCap
        {
            get
            {
                return _BangCap;
            }
            set
            {
                _BangCap = value;
            }
        }

        public string FileAnh
        {
            get
            {
                return _FileAnh;
            }
            set
            {
                _FileAnh = value;
            }
        }

        public DTO_HoSoNhanVien() { }

        public DTO_HoSoNhanVien(string manv, string dantoc, string tongiao, string tinhthanh, DateTime ngayvaolam, string bangcap, string fileanh)
        {
            this.MaNV = manv;
            this.DanToc = dantoc;
            this.TonGiao = tongiao;
            this.TinhThanh = tinhthanh;
            this.NgayVaolam = ngayvaolam;
            this.BangCap = bangcap;
            this.FileAnh = fileanh;
        }
    }
}
