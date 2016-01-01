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
    public class Baocaochi_BUS
    {
        public DataTable LoadDS(DateTime ngay)
        {
            Baocaochi_DAO t = new Baocaochi_DAO();
            return t.LoadDS(ngay);
        }
        public bool ThemBaoCao(Baocaochi_DTO bc)
        {
            Baocaochi_DAO t = new Baocaochi_DAO();
            return t.ThemBaoCao(bc);
        }
    }
}
