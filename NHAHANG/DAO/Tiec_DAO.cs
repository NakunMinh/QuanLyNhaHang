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
    public class Tiec_DAO
    {
        public DataTable LoadTiec()
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "SELECT * FROM TIEC";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new System.Data.DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public bool ThemTiec(Tiec_DTO tiec)
        {
            //kiem tra
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Id FROM TIEC WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd.Parameters["@Id"].Value = tiec.Id;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            if (reader.Read())
            {
                count++;
                string s = reader.GetString(0);
            }
            reader.Close();
            if (count == 1)
            {
                return false;
            }

            SqlConnection conn1 = ConnectToSQL.HamKetNoi();
            string str1 = "INSERT INTO TIEC(Id, Ngaytochuc, Gia) VALUES (@Id, @Ngaytochuc, @Gia)";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.CommandType = CommandType.Text;

            cmd1.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd1.Parameters.Add("@Ngaytochuc", SqlDbType.DateTime);
            cmd1.Parameters.Add("@Gia", SqlDbType.Float);

            cmd1.Parameters["@Id"].Value = tiec.Id;
            cmd1.Parameters["@Ngaytochuc"].Value = tiec.Ngaytochuc;
            cmd1.Parameters["@Gia"].Value = tiec.Gia;

            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();
            return true;
        }
        public bool XoaTiec(Tiec_DTO tiec)
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "DELETE FROM TIEC WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.NChar, 10);
            cmd.Parameters["@Id"].Value = tiec.Id;

            conn.Open();
            int t = cmd.ExecuteNonQuery();
            if (t < 1)
                return false;
            conn.Close();
            return true;
        }
        public bool CapNhatTiec(Tiec_DTO tiec)
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "UPDATE TIEC SET Ngaytochuc = @Ngaytochuc, Gia = @Gia WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@Ngaytochuc", SqlDbType.DateTime);
            cmd.Parameters.Add("@Gia", SqlDbType.Float);

            cmd.Parameters["@Id"].Value = tiec.Id;
            cmd.Parameters["@Ngaytochuc"].Value = tiec.Ngaytochuc;
            cmd.Parameters["@Gia"].Value = tiec.Gia;

            conn.Open();
            int t = cmd.ExecuteNonQuery();
            if (t < 1)
                return false;
            conn.Close();
            return true;
        }
        public bool CapNhatTongTien(string id, float tongtien)
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "UPDATE TIEC SET Gia = @Gia WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@Gia", SqlDbType.Float);

            cmd.Parameters["@Id"].Value = id;
            cmd.Parameters["@Gia"].Value = tongtien;

            conn.Open();
            int t = cmd.ExecuteNonQuery();
            if (t < 1)
                return false;
            conn.Close();
            return true;
        }
    }
}
