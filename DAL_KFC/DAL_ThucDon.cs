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
    public class DAL_ThucDon:DBConnect
    {
        //Lấy mã TD cuối
        public string getMaTDCuoi()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MATHUCDON FROM THUCDON", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mahdcuoi = dt.Rows[dt.Rows.Count - 1].Field<string>(0);
            string sohdmoi = (Convert.ToInt32(mahdcuoi.Substring(2)) + 1).ToString();
            string mahdmoi;
            if (Convert.ToInt32(sohdmoi) <= 9) mahdmoi = "TD0" + sohdmoi;
            else mahdmoi = "TD" + sohdmoi;
            cnn.Close();
            return mahdmoi;
        }
        //Load dgv
        public DataTable getAllThucDon()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT A.MATHUCDON, A.TENTHUCDON, B.TENNHOM, A.GIABAN, A.CHITIET, A.GIAMGIA FROM THUCDON A, NHOMTHUCDON B WHERE A.MANHOM = B.MANHOM", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Tìm thực đơn
        public DataTable findTD(string tentd)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT A.MATHUCDON, A.TENTHUCDON, B.TENNHOM, A.GIABAN, A.CHITIET, A.GIAMGIA FROM THUCDON A, NHOMTHUCDON B WHERE A.MANHOM = B.MANHOM AND A.TENTHUCDON like N'%{0}%'", tentd);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Load cbb Tên nhóm
        public DataTable getCbbTenNhom()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TENNHOM FROM NHOMTHUCDON", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy mã nhóm từ tên nhóm
        public string getMaNhom(string tennhom)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT MANHOM FROM NHOMTHUCDON WHERE TENNHOM = N'{0}'", tennhom);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt.Rows[0].Field<string>(0);
        }
        //thêm
        public bool themThucDon(DTO_ThucDon td)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themThucDon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaThucDon", td.MaTD);
                cmd.Parameters.AddWithValue("@TenThucDon", td.TenTD);
                cmd.Parameters.AddWithValue("@MaNhom", td.MaNhom);
                cmd.Parameters.AddWithValue("@ChiTiet", td.ChiTiet);
                cmd.Parameters.AddWithValue("@GiaBan", td.GiaBan);
                cmd.Parameters.AddWithValue("@GiamGia", td.GiamGia);
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
        //sửa
        public bool suaThucDon(DTO_ThucDon td)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaThucDon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaThucDon", td.MaTD);
                cmd.Parameters.AddWithValue("@TenThucDon", td.TenTD);
                cmd.Parameters.AddWithValue("@MaNhom", td.MaNhom);
                cmd.Parameters.AddWithValue("@ChiTiet", td.ChiTiet);
                cmd.Parameters.AddWithValue("@GiaBan", td.GiaBan);
                cmd.Parameters.AddWithValue("@GiamGia", td.GiamGia);
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
        //xóa
        public bool xoaThucDon(string matd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaThucDon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaThucDon", matd);
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
