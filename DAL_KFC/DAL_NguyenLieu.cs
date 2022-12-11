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
    public class DAL_NguyenLieu:DBConnect
    {
        //Lấy mã NL cuối
        public string getMaNLCuoi()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MANL FROM NGUYENLIEU", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahdcuoi = dt.Rows[dt.Rows.Count - 1].Field<string>(0);
            string sohdmoi = (Convert.ToInt32(mahdcuoi.Substring(2)) + 1).ToString();
            string mahdmoi;
            if (Convert.ToInt32(sohdmoi) <= 9) mahdmoi = "NL0" + sohdmoi;
            else mahdmoi = "NL" + sohdmoi;
            cnn.Close();
            return mahdmoi;
        }
        //Load dgv
        public DataTable getAllNguyenLieu()
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM NGUYENLIEU");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Tìm nguyên liệu
        public DataTable findNL(string tennl)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT * FROM NGUYENLIEU WHERE TENNL like N'%{0}%' ", tennl);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm nl
        public bool themNguyenLieu(DTO_NguyenLieu nl)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themNguyenLieu", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", nl.MaNL);
                cmd.Parameters.AddWithValue("@TenNL", nl.TenNL);
                cmd.Parameters.AddWithValue("@Donvi", nl.DonVi);
                cmd.Parameters.AddWithValue("@SLton", nl.SLTon);
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
        //sửa nl
        public bool suaNguyenLieu(DTO_NguyenLieu nl)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaNguyenLieu", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", nl.MaNL);
                cmd.Parameters.AddWithValue("@TenNL", nl.TenNL);
                cmd.Parameters.AddWithValue("@Donvi", nl.DonVi);
                cmd.Parameters.AddWithValue("@SLton", nl.SLTon);
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
        //xóa nl
        public bool xoaNguyenLieu(string manl)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaSLNguyenLieu", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", manl);
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
