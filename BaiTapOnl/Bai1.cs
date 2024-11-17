using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOnl
{
    public class Bai1
    {
        public List<int> CkeckSoChan(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }
    }
}
