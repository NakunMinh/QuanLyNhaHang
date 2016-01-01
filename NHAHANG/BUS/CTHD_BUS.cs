using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class CTHD_BUS
    {
        public static bool ThemCTHD(CTHD_DTO cthd)
        {
            return CTHD_DAO.ThemCTHD(cthd);
        }
        public static DataTable LoadCTHDTheoMHD(int mahoadon)
        {
            return CTHD_DAO.LoadCTHDTheoMHD(mahoadon);
        }
    }
}
