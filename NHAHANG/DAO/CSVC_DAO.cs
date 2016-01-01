using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class CSVC_DAO
    {
        public DataTable LoadCSVC()
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "SELECT * FROM CSVC";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new System.Data.DataTable();
            da.Fill(dtb);
            return dtb;
        }
        public bool ThemCSVC(CSVC_DTO csvc)
        {
            //kiem tra
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "SELECT Id FROM CSVC WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd.Parameters["@Id"].Value = csvc.Id;

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
            string str1 = "INSERT INTO CSVC(Id, Ten, Dongia, Soluong) VALUES (@Id, @Ten, @Dongia, @Soluong)";
            SqlCommand cmd1 = new SqlCommand(str1, conn);
            cmd1.CommandType = CommandType.Text;

            cmd1.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd1.Parameters.Add("@Ten", SqlDbType.NVarChar, 50);
            cmd1.Parameters.Add("@Dongia", SqlDbType.Float);
            cmd1.Parameters.Add("@Soluong", SqlDbType.Int);

            cmd1.Parameters["@Id"].Value = csvc.Id;
            cmd1.Parameters["@Ten"].Value = csvc.Ten;
            cmd1.Parameters["@Dongia"].Value = csvc.Dongia;
            cmd1.Parameters["@Soluong"].Value = csvc.Soluong;

            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();
            return true;
        }
        public bool XoaCSVC(CSVC_DTO csvc)
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "DELETE FROM CSVC WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", System.Data.SqlDbType.NChar, 10);
            cmd.Parameters["@Id"].Value = csvc.Id;

            conn.Open();
            int t = cmd.ExecuteNonQuery();
            if (t < 1)
                return false;
            conn.Close();
            return true;
        }
        public bool CapNhatCSVC(CSVC_DTO csvc)
        {
            SqlConnection conn = ConnectToSQL.HamKetNoi();
            string str = "UPDATE CSVC SET Ten = @Ten, Dongia = @Dongia, Soluong = @Soluong WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Id", SqlDbType.NChar, 10);
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Dongia", SqlDbType.Float);
            cmd.Parameters.Add("@Soluong", SqlDbType.Int);

            cmd.Parameters["@Id"].Value = csvc.Id;
            cmd.Parameters["@Ten"].Value = csvc.Ten;
            cmd.Parameters["@Dongia"].Value = csvc.Dongia;
            cmd.Parameters["@Soluong"].Value = csvc.Soluong;

            conn.Open();
            int t = cmd.ExecuteNonQuery();
            if (t < 1)
                return false;
            conn.Close();
            return true;
        }
    }
}
