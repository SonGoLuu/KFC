using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_KFC;

namespace DAL_KFC
{
    public class DAL_TienDua:DBConnect
    {
        //thêm tiền đưa
        //Thêm sp
        public bool themTienDua(DTO_TienDua td)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themTienDua", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", td.MaHD);
                cmd.Parameters.AddWithValue("@TienHang", td.TienHang);
                cmd.Parameters.AddWithValue("@GiamGia", td.GiamGia);
                cmd.Parameters.AddWithValue("@KhachDua", td.KhachDua);
                cmd.Parameters.AddWithValue("@TraLai", td.TraLai);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }

            return false;
        }
    }
}
