using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_KFC;
using DAL_KFC;

namespace BUS_KFC
{
    public class BUS_LuongChucDanh
    {
        DAL_LuongChucDanh l = new DAL_LuongChucDanh();
        public string getMaCDCuoi()
        {
            return l.getMaCDCuoi();
        }
        public DataTable loadDgvLuongChucDanh()
        {
            return l.loadDgvLuongChucDanh();
        }
        public bool themChucDanh(DTO_ChucDanh cd, DTO_LuongChucDanh lcd)
        {
            return l.themChucDanh(cd, lcd);
        }
        public bool suaChucDanh(DTO_ChucDanh cd, DTO_LuongChucDanh lcd)
        {
            return l.suaChucDanh(cd, lcd);
        }
        public bool xoaChucDanh(string macd)
        {
            return l.xoaChucDanh(macd);
        }
    }
}
