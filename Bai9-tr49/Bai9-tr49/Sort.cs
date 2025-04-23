using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9_tr49
{
    public class Sort
    {
        public void Display(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public int FindMaxValue(int[] arr)
        {
            int maxTempt = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxTempt)
                    maxTempt = arr[i];
            }
            return maxTempt;
        }

        public byte DemSoChuSo(long num)
        {
            byte soChuSo = 0;
            while (num > 0)
            {
                soChuSo++;
                num /= 10;
            }
            return soChuSo;
        }

        public void RSPass(byte chuSoHang, int[] arr)
        {
            int i, iQue;
            CQueue[] que = new CQueue[10];
            for(i = 0; i < 10; i++)
                que[i] = new CQueue();
            for (i = 0; i < arr.Length; i++)
            {
                int temp = arr[i] / (int)Math.Pow(10, chuSoHang);
                iQue = temp % 10;
                que[iQue].Enqueue(arr[i]);
            }

            i = 0;
            for (iQue = 0; iQue < 10; iQue++)
            {
                while (que[iQue].Count > 0)
                {
                    arr[i] = Convert.ToInt32(que[iQue].Dequeue().ToString());
                    i++;
                }
            }
        }

        public void RadixSort(int[] arr)
        {
            int maxValue = FindMaxValue(arr);
            byte soChuSo = DemSoChuSo(maxValue);
            for (byte i = 0; i < soChuSo; i++)
            {
                RSPass(i, arr);
                Console.Write($"Dãy sau chuyến {i + 1}:\t ");
                Display(arr);
            }
        }
    }
}
