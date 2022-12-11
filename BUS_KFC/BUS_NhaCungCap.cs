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
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap n = new DAL_NhaCungCap();
        public string getMaNCCCuoi()
        {
            return n.getMaNCCCuoi();
        }
        public DataTable getAllNhom()
        {
            return n.getAllNhom();
        }
        public bool themNCC(DTO_NhaCungCap ncc)
        {
            return n.themNCC(ncc);
        }
        public bool suaNCC(DTO_NhaCungCap ncc)
        {
            return n.suaNCC(ncc);
        }
        public bool xoaNCC(string mancc)
        {
            return n.xoaNCC(mancc);
        }    
    }
}
