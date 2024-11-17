using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapOnl
{
    public class Bai2
    {
        public int TinhHieu(int[] numbers)
        {
            int result = numbers[0];  
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];  
            }

            return result;
        }
    }
}
