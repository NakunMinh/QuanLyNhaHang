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
    public class Baocaothu_BUS
    {
        public DataTable LoadDS(DateTime ngay)
        {
            Baocaothu_DAO t = new Baocaothu_DAO();
            return t.LoadDS(ngay);
        }
        public bool ThemBaoCao(Baocaothu_DTO bc)
        {
            Baocaothu_DAO t = new Baocaothu_DAO();
            return t.ThemBaoCao(bc);
        }
    }
}
