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
    public class BUS_CTTD
    {
        DAL_CTTD c = new DAL_CTTD();
        public DataTable getAllCTTD()
        {
            return c.getAllCTTD();
        }
        public string getTenTD(string matd)
        {
            return c.getTenTD(matd);
        }
        public string getTenSP(string masp)
        {
            return c.getTenSP(masp);
        }
        public DataTable findCTTD(string tentd)
        {
            return c.findCTTD(tentd);
        }
        public bool themCTTD(DTO_CTTD cttd)
        {
            return c.themCTTD(cttd);
        }
        public bool suaCTTD(DTO_CTTD cttd)
        {
            return c.suaCTTD(cttd);
        }
        public bool xoaCTTD(string matd, string masp)
        {
            return c.xoaCTTD(matd, masp);
        }
    }
}
