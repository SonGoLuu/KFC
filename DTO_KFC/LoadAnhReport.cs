using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KFC
{
    public class LoadAnhReport
    {
        public byte[] Photo { get; set; }
        public LoadAnhReport(byte[] photo)
        {
            this.Photo = photo;
        }
    }
}
