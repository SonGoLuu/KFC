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
    public class BUS_TienDua
    {
        DAL_TienDua t = new DAL_TienDua();
        public bool themTienDua(DTO_TienDua td)
        {
           return t.themTienDua(td);
        }
    }
}
