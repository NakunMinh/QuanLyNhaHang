using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Mon_DTO
    {
        string _mamon;

        public string Mamon
        {
            get { return _mamon; }
            set { _mamon = value; }
        }
        string _tenmon;

        public string Tenmon
        {
            get { return _tenmon; }
            set { _tenmon = value; }
        }
        float _dongia;

        public float Dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }
        string _loai;

        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
        public Mon_DTO(string ma, string ten, float dg, string loai)
        {
            _mamon = ma;
            _tenmon = ten;
            _dongia = dg;
            _loai = loai;
        }
    }
}
