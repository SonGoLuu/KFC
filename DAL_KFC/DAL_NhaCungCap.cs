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
    public class DAL_NhaCungCap:DBConnect
    {
        //Lấy mã NCC cuối
        public string getMaNCCCuoi()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MANCC FROM NHACUNGCAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahdcuoi = dt.Rows[dt.Rows.Count - 1].Field<string>(0);
            string sohdmoi = (Convert.ToInt32(mahdcuoi.Substring(3)) + 1).ToString();
            string mahdmoi;
            if (Convert.ToInt32(sohdmoi) <= 9) mahdmoi = "NCC0" + sohdmoi;
            else mahdmoi = "NCC" + sohdmoi;
            cnn.Close();
            return mahdmoi;
        }
        //Lấy all nhà cung cấp
        public DataTable getAllNhom()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHACUNGCAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm
        public bool themNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themNhaCungCap", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
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
        //Sửa
        public bool suaNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaNhaCungCap", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
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
        //Xóa
        public bool xoaNCC(string mancc)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaNhaCungCap", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", mancc);
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
