using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Configuration;

namespace DAO
{
    public class ConnectToSQL
    {
        public static SqlConnection HamKetNoi()
        {
            string conn = ConfigurationManager.ConnectionStrings["NHAHANG"].ConnectionString;
            SqlConnection cnn = new SqlConnection(conn);
            return cnn;
        }
    }
}
