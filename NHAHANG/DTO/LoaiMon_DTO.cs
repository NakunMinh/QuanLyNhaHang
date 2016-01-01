using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiMon_DTO
    {
        string _maloai;

        public string Maloai
        {
            get { return _maloai; }
            set { _maloai = value; }
        }
        string _tenloai;

        public string Tenloai
        {
            get { return _tenloai; }
            set { _tenloai = value; }
        }
        public LoaiMon_DTO(string ma, string ten)
        {
            _maloai = ma;
            _tenloai = ten;
        }
    }
}
