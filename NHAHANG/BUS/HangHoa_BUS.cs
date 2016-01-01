using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HangHoa_BUS
    {
        public DataTable LoadHangHoa()
        {
            HangHoa_DAO t = new HangHoa_DAO();
            return t.LoadHangHoa();
        }
        public bool ThemHangHoa(HangHoa_DTO hh)
        {
            HangHoa_DAO t = new HangHoa_DAO();
            return t.ThemHangHoa(hh);
        }
        public bool XoaHangHoa(HangHoa_DTO hh)
        {
            HangHoa_DAO t = new HangHoa_DAO();
            return t.XoaHangHoa(hh);
        }
        public bool CapNhatHangHoa(HangHoa_DTO hh)
        {
            HangHoa_DAO t = new HangHoa_DAO();
            return t.CapNhatHangHoa(hh);
        }
    }
}
