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
    public class BUS_NVChucDanh
    {
        DAL_NVChucDanh n = new DAL_NVChucDanh();
        public DataTable getAllChucDanh()
        {
            return n.getAllChucDanh();
        }
        public string getMaCD(string TenCD)
        {
            return n.getMaCD(TenCD);
        }
        public DataTable getcbbNV()
        {
            return n.getcbbNV();
        }
        public DataTable getcbbCD()
        {
            return n.getcbbCD();
        }
        public DataTable getcbbNVMoi()
        {
            return n.getcbbNVMoi();
        }
        public bool themsuaNVChucDanh(DTO_NhanVien nv)
        {
            return n.themsuaNVChucDanh(nv);
        }
        public bool xoaNVChucDanh(string manv)
        {
            return n.xoaNVChucDanh(manv);
        }    
    }
}
