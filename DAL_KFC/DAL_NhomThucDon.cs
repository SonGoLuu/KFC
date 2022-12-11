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
    public class DAL_NhomThucDon:DBConnect
    {
        //Lấy mã NH cuối
        public string getMaNHCuoi()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MANHOM FROM NHOMTHUCDON", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahdcuoi = dt.Rows[dt.Rows.Count - 1].Field<string>(0);
            string sohdmoi = (Convert.ToInt32(mahdcuoi.Substring(2)) + 1).ToString();
            string mahdmoi;
            if (Convert.ToInt32(sohdmoi) <= 9) mahdmoi = "NH0" + sohdmoi;
            else mahdmoi = "NH" + sohdmoi;
            cnn.Close();
            return mahdmoi;
        }
        //Lấy all nhóm thực đơn
        public DataTable getAllNhom()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHOMTHUCDON", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm
        public bool themNhom(DTO_NhomThucDon nhom)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themNhomThucDon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNhom", nhom.MaNhom);
                cmd.Parameters.AddWithValue("@TenNhom", nhom.TenNhom);
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
        public bool suaNhom(DTO_NhomThucDon nhom)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaNhomThucDon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNhom", nhom.MaNhom);
                cmd.Parameters.AddWithValue("@TenNhom", nhom.TenNhom);
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
        public bool xoaNhom(string manhom)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaNhomThucDon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNhom", manhom);
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
