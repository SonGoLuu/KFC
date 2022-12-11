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
    public class DAL_CTTD:DBConnect
    {
        //Load dgv
        public DataTable getAllCTTD()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT A.MATHUCDON, B.TENTHUCDON, A.MASP, C.TENSP, A.SOLUONG FROM CHITIETTHUCDON A, THUCDON B, SANPHAM C WHERE A.MATHUCDON = B.MATHUCDON AND A.MASP = C.MASP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy tên thực đơn
        public string getTenTD(string matd)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT TENTHUCDON FROM THUCDON WHERE MATHUCDON ='{0}'", matd);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return dt.Rows[0].Field<string>(0);
            else return "";
        }
        //Lấy tên sản phẩm
        public string getTenSP(string masp)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT TENSP FROM SANPHAM WHERE MASP ='{0}'", masp);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return dt.Rows[0].Field<string>(0);
            else return "";
        }
        //Tìm chi tiết thực đơn
        public DataTable findCTTD(string tentd)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT A.MATHUCDON, B.TENTHUCDON, A.MASP, C.TENSP, A.SOLUONG FROM CHITIETTHUCDON A, THUCDON B, SANPHAM C WHERE A.MATHUCDON = B.MATHUCDON AND A.MASP = C.MASP AND B.TENTHUCDON like N'%{0}%'", tentd);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm
        public bool themCTTD(DTO_CTTD cttd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themCTTD", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaThucDon", cttd.MaTD);
                cmd.Parameters.AddWithValue("@MaSP", cttd.MaSP);
                cmd.Parameters.AddWithValue("@SoLuong", cttd.SoLuong);
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
        public bool suaCTTD(DTO_CTTD cttd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaCTTD", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaThucDon", cttd.MaTD);
                cmd.Parameters.AddWithValue("@MaSP", cttd.MaSP);
                cmd.Parameters.AddWithValue("@SoLuong", cttd.SoLuong);
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
        public bool xoaCTTD(string matd, string masp)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaCTTD", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaThucDon", matd);
                cmd.Parameters.AddWithValue("@MaSP", masp);
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
