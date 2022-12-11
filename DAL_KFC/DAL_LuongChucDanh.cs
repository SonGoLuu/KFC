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
    public class DAL_LuongChucDanh:DBConnect
    {
        //Lấy mã cd cuối
        public string getMaCDCuoi()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MACD FROM CHUCDANH", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahdcuoi = dt.Rows[dt.Rows.Count - 1].Field<string>(0);
            string sohdmoi = (Convert.ToInt32(mahdcuoi.Substring(2)) + 1).ToString();
            string mahdmoi;
            if (Convert.ToInt32(sohdmoi) <= 9) mahdmoi = "CD0" + sohdmoi;
            else mahdmoi = "CD" + sohdmoi;
            cnn.Close();
            return mahdmoi;
        }
        //Load bảng dgv
        public DataTable loadDgvLuongChucDanh()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT A.TENCD, B.TIENLUONG, B.PHUCAP  FROM CHUCDANH A, LUONGCHUCDANH B WHERE A.MACD = B.MACD", cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien;
        }
        //Thêm CD và Lương
        public bool themChucDanh(DTO_ChucDanh cd, DTO_LuongChucDanh lcd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                //thêm chức danh
                SqlCommand cmd = new SqlCommand("themChucDanh", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCD", cd.MaCD);
                cmd.Parameters.AddWithValue("@TenCD", cd.TenCD);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                { 
                    //thêm lương chức danh
                    SqlCommand cmd2 = new SqlCommand("themLuongChucDanh", cnn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@MaCD", lcd.MaCD);
                    cmd2.Parameters.AddWithValue("@TienLuong", lcd.TienLuong);
                    cmd2.Parameters.AddWithValue("@PhuCap", lcd.PhuCap);
                    // Query và kiểm tra
                    if (cmd2.ExecuteNonQuery() > 0)
                        return true;
                 }
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
        //sửa
        public bool suaChucDanh(DTO_ChucDanh cd, DTO_LuongChucDanh lcd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                //sửa chức danh
                SqlCommand cmd = new SqlCommand("suaChucDanh", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCD", cd.MaCD);
                cmd.Parameters.AddWithValue("@TenCD", cd.TenCD);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    //thêm lương chức danh
                    SqlCommand cmd2 = new SqlCommand("suaLuongChucDanh", cnn);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("@MaCD", lcd.MaCD);
                    cmd2.Parameters.AddWithValue("@TienLuong", lcd.TienLuong);
                    cmd2.Parameters.AddWithValue("@PhuCap", lcd.PhuCap);
                    // Query và kiểm tra
                    if (cmd2.ExecuteNonQuery() > 0)
                        return true;
                }
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
        //xóa
        public bool xoaChucDanh(string macd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaChucDanh", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCD", macd);
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
