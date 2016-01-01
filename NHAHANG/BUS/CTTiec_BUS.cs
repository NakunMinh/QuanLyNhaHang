using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class CTTiec_BUS
    {
        public bool ThemCTTiec(CTTiec_DTO cttiec)
        {
            CTTiec_DAO t = new CTTiec_DAO();
            return t.ThemCTTiec(cttiec);
        }
        public DataTable LoadCTHDTheoIDTiec(string Id)
        {
            CTTiec_DAO t = new CTTiec_DAO();
            return t.LoadCTHDTheoIDTiec(Id);
        }
    }
}
