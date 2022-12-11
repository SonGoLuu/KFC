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
    public class BUS_PhanQuyen
    {
        DAL_PhanQuyen p = new DAL_PhanQuyen();
        public DataTable getAllTenDangNhap()
        {
            return p.getAllTenDangNhap();
        }
        public string getTenNV(string tentaikhoan)
        {
            return p.getTenNV(tentaikhoan);
        }
        public string getTenQuyen(string tentaikhoan)
        {
            return p.getTenQuyen(tentaikhoan);
        }    
        public bool themsuaPhanQuyen(DTO_PhanQuyen pq)
        {
            return p.themsuaPhanQuyen(pq);
        }    
    }
}
