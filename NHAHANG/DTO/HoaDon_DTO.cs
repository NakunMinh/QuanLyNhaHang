using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        string _mahoadon;

        public string Mahoadon
        {
            get { return _mahoadon; }
            set { _mahoadon = value; }
        }
        int _ban;

        public int Ban
        {
            get { return _ban; }
            set { _ban = value; }
        }

        float _tongtien;

        public float Tongtien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }
        public HoaDon_DTO(int ban, float tongtien)
        {
            _ban = ban;
            _tongtien = tongtien;
        }
    }
}
