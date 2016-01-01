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
    public class CSVC_BUS
    {
        public DataTable LoadCSVC()
        {
            DAO.CSVC_DAO t = new CSVC_DAO();
            return t.LoadCSVC();
        }
        public bool ThemCSVC(CSVC_DTO csvc)
        {
            CSVC_DAO t = new CSVC_DAO();
            return t.ThemCSVC(csvc);
        }
        public bool XoaCSVC(CSVC_DTO csvc)
        {
            CSVC_DAO t = new CSVC_DAO();
            return t.XoaCSVC(csvc);
        }
        public bool CapNhatCSVC(CSVC_DTO csvc)
        {
            CSVC_DAO t = new CSVC_DAO();
            return t.CapNhatCSVC(csvc);
        }
    }
}
