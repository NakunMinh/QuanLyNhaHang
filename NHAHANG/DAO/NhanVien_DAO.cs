using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVien_DAO
    {
        public static DataTable LoadDSNhanVien()
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Manhanvien, Tennhanvien, Ngaysinh, Gioitinh, CMND, Diachi, Sdt, Email, Luong, Tenloainhanvien FROM NHANVIEN, LOAINHANVIEN WHERE IdLoainhanvien = Loainhanvien";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public DataTable LoadDSLuong()
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Tennhanvien, Tenloainhanvien, Chisoluong FROM NHANVIEN, LOAINHANVIEN WHERE IdLoainhanvien = Loainhanvien";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public string LayTenChucVuTheoMa(string manhanvien)
        {
            string t = "";
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = @"SELECT Tenloainhanvien FROM NHANVIEN, LOAINHANVIEN WHERE IdLoainhanvien = Loainhanvien AND Manhanvien = @Manhanvien";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Manhanvien", SqlDbType.NChar, 10);
            cmd.Parameters["@Manhanvien"].Value = manhanvien;
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                t = reader.GetString(0);
            }
            reader.Close();
            return t;
        }
        public string LayTenPasswordTheoMa(string manhanvien)
        {
            string t = "";
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = @"SELECT Password FROM NHANVIEN WHERE Manhanvien = @Manhanvien";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Manhanvien", SqlDbType.NChar, 10);
            cmd.Parameters["@Manhanvien"].Value = manhanvien;
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                t = reader.GetString(0);
            }
            reader.Close();
            return t;
        }
        public string LayTenTheoMa(string manhanvien)
        {
            string t = "";
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = @"SELECT Tennhanvien FROM NHANVIEN WHERE Manhanvien = @Manhanvien";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Manhanvien", SqlDbType.NChar, 10);
            cmd.Parameters["@Manhanvien"].Value = manhanvien;
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                t = reader.GetString(0);
            }
            reader.Close();
            return t;
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            SqlConnection kt = ConnectToSQL.HamKetNoi();
            string sql = "SELECT Manhanvien FROM NHANVIEN WHERE Manhanvien = @Manhanvien";
            SqlCommand cmd1 = new SqlCommand(sql, kt);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("@Manhanvien", SqlDbType.VarChar, 10);
            cmd1.Parameters["@Manhanvien"].Value = nv.Manhanvien;

            kt.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
            int count = 0;
            if (reader.Read())
            {
                count++;
                string s = reader.GetString(0);
            }
            reader.Close();
            if (count == 1)
            {
                //MessageBox.Show("Sinh vien da ton tai!");
                return false;
            }


            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "INSERT INTO NHANVIEN(Manhanvien, Tennhanvien, Ngaysinh, Gioitinh, CMND, Diachi, Sdt, Email, Luong, Loainhanvien, Password) VALUES (@Manhanvien, @Tennhanvien, @Ngaysinh, @Gioitinh, @CMND, @Diachi, @Sdt, @Email, @Luong, @Loainhanvien, @Password)";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Manhanvien", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Tennhanvien", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date);
            cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar, 4);
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@Sdt", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Luong", SqlDbType.Float);
            cmd.Parameters.Add("@Loainhanvien", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@Password", SqlDbType.NChar, 10);

            cmd.Parameters["@Manhanvien"].Value = nv.Manhanvien;
            cmd.Parameters["@Tennhanvien"].Value = nv.Tennhanvien;
            cmd.Parameters["@Ngaysinh"].Value = nv.Ngaysinh;
            cmd.Parameters["@Gioitinh"].Value = nv.Gioitinh;
            cmd.Parameters["@CMND"].Value = nv.Cmnd;
            cmd.Parameters["@Diachi"].Value = nv.Diachi;
            cmd.Parameters["@Sdt"].Value = nv.Sdt;
            cmd.Parameters["@Email"].Value = nv.Email;
            cmd.Parameters["@Luong"].Value = nv.Luong;
            cmd.Parameters["@Loainhanvien"].Value = nv.Chucvu;
            cmd.Parameters["@Password"].Value = nv.Password;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;
        }
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "DELETE FROM NHANVIEN WHERE Manhanvien = @Manhanvien";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Manhanvien", SqlDbType.VarChar, 10);

            cmd.Parameters["@Manhanvien"].Value = nv.Manhanvien;

            cnn.Open();
            int count = cmd.ExecuteNonQuery();
            if (count < 1)
            { return false; }
            cnn.Close();
            return true;
        }
        public static bool CapNhatNhanVien(NhanVien_DTO nv)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "UPDATE NHANVIEN SET Manhanvien = @Manhanvien, Tennhanvien = @Tennhanvien, Ngaysinh = @Ngaysinh, Gioitinh = @Gioitinh, CMND = @CMND, Diachi = @Diachi, Sdt = @Sdt, Email = @Email, Luong = @Luong WHERE Manhanvien = @Manhanvien";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Manhanvien", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Tennhanvien", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date);
            cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar, 4);
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@Sdt", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@Luong", SqlDbType.Float);

            cmd.Parameters["@Manhanvien"].Value = nv.Manhanvien;
            cmd.Parameters["@Tennhanvien"].Value = nv.Tennhanvien;
            cmd.Parameters["@Ngaysinh"].Value = nv.Ngaysinh;
            cmd.Parameters["@Gioitinh"].Value = nv.Gioitinh;
            cmd.Parameters["@CMND"].Value = nv.Cmnd;
            cmd.Parameters["@Diachi"].Value = nv.Diachi;
            cmd.Parameters["@Sdt"].Value = nv.Sdt;
            cmd.Parameters["@Email"].Value = nv.Email;
            cmd.Parameters["@Luong"].Value = nv.Luong;

            cnn.Open();
            int count = cmd.ExecuteNonQuery();
            if (count < 1)
            { return false; }
            cnn.Close();
            return true;
        }
        public static DataTable TimKiemTheoTen(string ten)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Manhanvien, Tennhanvien, Ngaysinh, Gioitinh, CMND, Diachi, Sdt, Email, Luong FROM NHANVIEN WHERE Tennhanvien = @Tennhanvien";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Tennhanvien", SqlDbType.NVarChar, 50);
            cmd.Parameters["@Tennhanvien"].Value = ten;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public static DataTable TimKiemTheoGioiTinh(string gioitinh)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Manhanvien, Tennhanvien, Ngaysinh, Gioitinh, CMND, Diachi, Sdt, Email, Luong FROM NHANVIEN WHERE Gioitinh = @Gioitinh";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar, 4);
            cmd.Parameters["@Gioitinh"].Value = gioitinh;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public static DataTable TimKiemTheoChucVu(string chucvu)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Manhanvien, Tennhanvien, Ngaysinh, Gioitinh, CMND, Diachi, Sdt, Email, Luong FROM NHANVIEN, LOAINHANVIEN WHERE IdLoainhanvien = Loainhanvien AND Tenloainhanvien = @Chucvu";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Chucvu", SqlDbType.NChar, 10);
            cmd.Parameters["@Chucvu"].Value = chucvu;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
    }
}
