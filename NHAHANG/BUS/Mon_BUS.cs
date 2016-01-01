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
    public class Mon_BUS
    {
        public static DataTable LoadDSMon()
        {
            return Mon_DAO.LoadDSMon();
        }
        public static bool ThemMon(Mon_DTO mon)
        {
            return Mon_DAO.ThemMon(mon);
        }
        public static bool XoaMon(Mon_DTO mon)
        {
            return Mon_DAO.XoaMon(mon);
        }
        public static bool CapNhatMon(Mon_DTO mon)
        {
            return Mon_DAO.CapNhatMon(mon);
        }
        public static DataTable LoadDSMonTheoLoai(string tenloai)
        {
            return Mon_DAO.LoadDSMonTheoLoai(tenloai);
        }
    }
}
