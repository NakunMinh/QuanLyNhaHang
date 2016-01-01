using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tiec_DTO
    {
        string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        DateTime _ngaytochuc;

        public DateTime Ngaytochuc
        {
            get { return _ngaytochuc; }
            set { _ngaytochuc = value; }
        }
        float _gia;

        public float Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public Tiec_DTO(string id, DateTime ngaytochuc, float gia)
        {
            _id = id;
            _ngaytochuc = ngaytochuc;
            _gia = gia;
        }
    }
}
