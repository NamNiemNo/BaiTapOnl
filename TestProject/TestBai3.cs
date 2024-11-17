using BaiTapOnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class TestBai3
    {
        private Bai3 _bai3 = new Bai3();
        [Test]
        public void TestThemXe()
        {
            var xe = new XeOto(1, "Toyota", 500000, "Ghi chú xe Toyota");

            _bai3.Them(xe);
            var danhSach = _bai3.LayDanhSach();
            Assert.AreEqual(1, danhSach.Count);
            Assert.AreEqual(xe.Ten, danhSach.First().Ten);
        }

        [Test]
        public void TestSuaXe()
        {
            var xe = new XeOto(1, "Toyota", 500000, "Ghi chú xe Toyota");
            _bai3.Them(xe);
            var xeMoi = new XeOto(1, "Honda", 600000, "Ghi chú xe Honda");
            _bai3.Sua(xeMoi);

            var danhSach = _bai3.LayDanhSach();
            var xeSua = danhSach.FirstOrDefault(x => x.Ma == 1);
            Assert.IsNotNull(xeSua);
            Assert.AreEqual(xeMoi.Ten, xeSua.Ten);
            Assert.AreEqual(xeMoi.Gia, xeSua.Gia);
            Assert.AreEqual(xeMoi.Ghichu, xeSua.Ghichu);
        }

        [Test]
        public void TestXoaXe()
        {
            var xe = new XeOto(1, "Toyota", 500000, "Ghi chú xe Toyota");
            _bai3.Them(xe);
            _bai3.Xoa(1);
            var danhSach = _bai3.LayDanhSach();
            var xeXoa = danhSach.FirstOrDefault(x => x.Ma == 1);
            Assert.IsNull(xeXoa); 
        }

        [Test]
        public void TestDanhSachXeRong()
        {
            var danhSach = _bai3.LayDanhSach();
            Assert.AreEqual(0, danhSach.Count);
        }
    }
}

