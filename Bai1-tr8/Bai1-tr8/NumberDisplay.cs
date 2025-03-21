using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr8
{
    public class NumberDisplay
    {
        public void Display(long n)
        {
            int batchSize = 10000;
            char[] buffer = new char[batchSize * 6];
            int index = 0;
            for (long i = 1; i <= n; i++)
            {
                string numberStr = i.ToString();
                if (numberStr.Length <= buffer.Length - index)
                {
                    numberStr.CopyTo(0, buffer, index, numberStr.Length);
                    buffer[index + numberStr.Length] = ' ';
                    index += numberStr.Length + 1;
                }
                if (index >= buffer.Length - 6 || i == n)
                {
                    Console.Write(new string(buffer, 0, index));
                    index = 0;
                }
            }
            Console.WriteLine();
        }
    }
}
