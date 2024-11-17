    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOnl
{
    public class XeOto
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public decimal Gia { get; set; }
        public string Ghichu { get; set; }

        public XeOto(int ma, string ten, decimal gia, string ghichu)
        {
            Ma = ma;
            Ten = ten;
            Gia = gia;
            Ghichu = ghichu;
        }
    }
    public class Bai3
    {
        private List<XeOto> _xeOtos = new List<XeOto>();

        public void Them(XeOto xe)
        {
            _xeOtos.Add(xe);
        }

        public void Sua(XeOto xe)
        {
            var Maxe = _xeOtos.FirstOrDefault(x => x.Ma == xe.Ma);
            if (Maxe != null)
            {
                Maxe.Ten = xe.Ten;
                Maxe.Gia = xe.Gia;
                Maxe.Ghichu = xe.Ghichu;
            }
        }

        public void Xoa(int ma)
        {
            var Maxe = _xeOtos.FirstOrDefault(x => x.Ma == ma);
            if (Maxe != null)
            {
                _xeOtos.Remove(Maxe);
            }
        }

        public List<XeOto> LayDanhSach()
        {
            return _xeOtos;
        }
    }
}
