using BaiTapOnl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Testbai2
    {
        private Bai2 _bai2 = new Bai2();
        [Test]
        public void TestTinhHieu()
        {
            int[] input = { 10, 5 ,1,1};
            int expected = 3; 
            Assert.That(_bai2.TinhHieu(input), Is.EqualTo(expected));
        }
    }
}
