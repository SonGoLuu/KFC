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
    public class BUS_NhomThucDon
    {
        DAL_NhomThucDon n = new DAL_NhomThucDon();
        public string getMaNHCuoi()
        {
            return n.getMaNHCuoi();
        }
        public DataTable getAllNhom()
        {
            return n.getAllNhom();
        }
        public bool themNhom(DTO_NhomThucDon nhom)
        {
            return n.themNhom(nhom);
        }
        public bool suaNhom(DTO_NhomThucDon nhom)
        {
            return n.suaNhom(nhom);
        }
        public bool xoaNhom(string manhom)
        {
            return n.xoaNhom(manhom);
        }
    }
}
