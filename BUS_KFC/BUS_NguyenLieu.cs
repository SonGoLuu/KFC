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
    public class BUS_NguyenLieu
    {
        DAL_NguyenLieu n = new DAL_NguyenLieu();
        public string getMaNLCuoi()
        {
            return n.getMaNLCuoi();
        }
        public DataTable getAllNguyenLieu()
        {
            return n.getAllNguyenLieu();
        }
        public DataTable findNL(string tennl)
        {
            return n.findNL(tennl);
        }
        public bool themNguyenLieu(DTO_NguyenLieu nl)
        {
            return n.themNguyenLieu(nl);
        }
        public bool suaNguyenLieu(DTO_NguyenLieu nl)
        {
            return n.suaNguyenLieu(nl);
        }
        public bool xoaNguyenLieu(string manl)
        {
            return n.xoaNguyenLieu(manl);
        }
    }
}
