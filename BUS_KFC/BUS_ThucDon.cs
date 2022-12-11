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
    public class BUS_ThucDon
    {
        DAL_ThucDon t = new DAL_ThucDon();
        public string getMaTDCuoi()
        {
            return t.getMaTDCuoi();
        }
        public DataTable getAllThucDon()
        {
            return t.getAllThucDon();
        }
        public DataTable findTD(string tentd)
        {
            return t.findTD(tentd);
        }
        public DataTable getCbbTenNhom()
        {
            return t.getCbbTenNhom();
        }
        public string getMaNhom(string tennhom)
        {
            return t.getMaNhom(tennhom);
        }
        public bool themThucDon(DTO_ThucDon td)
        {
            return t.themThucDon(td);
        }
        public bool suaThucDon(DTO_ThucDon td)
        {
            return t.suaThucDon(td);
        }
        public bool xoaThucDon(string matd)
        {
            return t.xoaThucDon(matd);
        }

    }
}
