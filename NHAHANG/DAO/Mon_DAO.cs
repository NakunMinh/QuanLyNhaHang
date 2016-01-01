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
    public class Mon_DAO
    {
        public static DataTable LoadDSMon()
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Mamon, Tenmon, Dongia, Loai FROM MON";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public static bool ThemMon(Mon_DTO mon)
        {
            SqlConnection kt = ConnectToSQL.HamKetNoi();
            string sql = "SELECT Mamon FROM MON WHERE Mamon = @Mamon";
            SqlCommand cmd1 = new SqlCommand(sql, kt);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("@Mamon", SqlDbType.VarChar, 10);
            cmd1.Parameters["@Mamon"].Value = mon.Mamon;

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
            string str = "INSERT INTO MON(Mamon, Tenmon, Dongia, Loai) VALUES (@Mamon, @Tenmon, @Dongia, @Loai)";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Mamon", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Tenmon", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Dongia", SqlDbType.Float);
            cmd.Parameters.Add("@Loai", SqlDbType.VarChar, 10);

            cmd.Parameters["@Mamon"].Value = mon.Mamon;
            cmd.Parameters["@Tenmon"].Value = mon.Tenmon;
            cmd.Parameters["@Dongia"].Value = mon.Dongia;
            cmd.Parameters["@Loai"].Value = mon.Loai;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return true;
        }
        public static bool XoaMon(Mon_DTO mon)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "DELETE FROM MON WHERE Mamon = @Mamon";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Mamon", SqlDbType.VarChar, 10);

            cmd.Parameters["@Mamon"].Value = mon.Mamon;

            cnn.Open();
            int count = cmd.ExecuteNonQuery();
            if (count < 1)
            { return false; }
            cnn.Close();
            return true;
        }
        public static bool CapNhatMon(Mon_DTO mon)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "UPDATE MON SET Tenmon = @Tenmon, Dongia = @Dongia, Loai = @Loai WHERE Mamon = @Mamon";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Mamon", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@Tenmon", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Dongia", SqlDbType.Float);
            cmd.Parameters.Add("@Loai", SqlDbType.VarChar, 10);

            cmd.Parameters["@Mamon"].Value = mon.Mamon;
            cmd.Parameters["@Tenmon"].Value = mon.Tenmon;
            cmd.Parameters["@Dongia"].Value = mon.Dongia;
            cmd.Parameters["@Loai"].Value = mon.Loai;

            cnn.Open();
            int count = cmd.ExecuteNonQuery();
            if (count < 1)
            { return false; }
            cnn.Close();
            return true;
        }
        public static DataTable LoadDSMonTheoLoai(string tenloai)
        {
            SqlConnection cnn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Tenmon, Dongia FROM MON WHERE Loai = @Loai";
            SqlCommand cmd = new SqlCommand(str, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Loai", SqlDbType.NVarChar, 50);
            cmd.Parameters["@Loai"].Value = tenloai;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            return dtb;
        }
    }
}
