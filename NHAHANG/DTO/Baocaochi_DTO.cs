using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Baocaochi_DTO
    {
        DateTime _ngay;

        public DateTime Ngay
        {
            get { return _ngay; }
            set { _ngay = value; }
        }
        string _loai;

        public string Loai
        {
            get { return _loai; }
            set { _loai = value; }
        }
        float _tien;

        public float Tien
        {
            get { return _tien; }
            set { _tien = value; }
        }
        public Baocaochi_DTO(DateTime ngay, string loai, float tien)
        {
            _ngay = ngay;
            _loai = loai;
            _tien = tien;
        }
    }
}
