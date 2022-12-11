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
    public class BUS_BangKeLuong
    {
        DAL_BangKeLuong b = new DAL_BangKeLuong();
        public DataTable loadDgvBangKeLuong(string thangnam)
        {
            return b.loadDgvBangKeLuong(thangnam);
        }
        public bool themBangKeLuong(DTO_BangKeLuong bkl)
        {
            return b.themBangKeLuong(bkl);
        }    
    }
}
