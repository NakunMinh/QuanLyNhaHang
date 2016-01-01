using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class LoaiMon_DAO
    {
        public static DataTable LoadDSLoaiMon()
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Maloaimon, Tenloaimon FROM LOAIMON";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public static bool ThemLoaiMon(LoaiMon_DTO loai)
        {
            SqlConnection kt = ConnectToSQL.HamKetNoi();
            string sql = "SELECT Maloaimon FROM LOAIMON WHERE Maloaimon = @Maloaimon";
            SqlCommand cmd1 = new SqlCommand(sql, kt);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("@Maloaimon", SqlDbType.VarChar, 10);
            cmd1.Parameters["@Maloaimon"].Value = loai.Maloai;

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
            string str = "INSERT INTO LOAIMON(Maloaimon, Tenloaimon) VALUES (@Maloaimon, @Tenloaimon)";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Maloaimon", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Tenloaimon", SqlDbType.NVarChar, 50);

            cmd.Parameters["@Maloaimon"].Value = loai.Maloai;
            cmd.Parameters["@Tenloaimon"].Value = loai.Tenloai;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;
        }
        public static bool XoaLoaiMon(LoaiMon_DTO loai)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "DELETE FROM LOAIMON WHERE Maloaimon = @Maloaimon";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Maloaimon", SqlDbType.VarChar, 10);

            cmd.Parameters["@Maloaimon"].Value = loai.Maloai;

            cnn.Open();
            int count = cmd.ExecuteNonQuery();
            if (count < 1)
            { return false; }
            cnn.Close();
            return true;
        }
        public static bool CapNhatLoaiMon(LoaiMon_DTO loai)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "UPDATE LOAIMON SET Tenloaimon = @Tenloaimon WHERE Maloaimon = @Maloaimon";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Maloaimon", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Tenloaimon", SqlDbType.NVarChar, 50);

            cmd.Parameters["@Maloaimon"].Value = loai.Maloai;
            cmd.Parameters["@Tenloaimon"].Value = loai.Tenloai;

            cnn.Open();
            int count = cmd.ExecuteNonQuery();
            if (count < 1)
            { return false; }
            cnn.Close();
            return true;
        }
        public static DataTable DSMaLoaiMon()
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Maloaimon FROM LOAIMON";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
    }
}
