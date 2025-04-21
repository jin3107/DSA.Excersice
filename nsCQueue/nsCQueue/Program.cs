using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsCQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int[] arr = { 19, 133, 60, 2450, 35, 9, 638, 478 };
            Console.Write("\tRadix Sort");
            Console.Write("\nDãy bắt đầu:\t\t ");
            DisplayArray(arr);
            RadixSort(arr);
            Console.Write("\n\nDãy đã sắp xếp:\t\t ");
            DisplayArray(arr);

            Console.Read();
        }

        static private void RSPass(byte chusohang, int[] arr)
        {
            int iQue;
            Cqueue[] que = new Cqueue[10];
            for (iQue = 0; iQue <= 9; iQue++)
                que[iQue] = new Cqueue();

            // Bước 1
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                int temp;
                temp = arr[i] / (int)Math.Pow(10, chusohang);
                iQue = temp % 10;

                /* 3 câu lệnh trên tương đương khối câu lệnh sau:
                switch (chusohang)
                {
                   case 0:
                        temp = arr[i];
                        iQue = temp % 10;
                        break;
                   case 1:
                        temp = arr[i] / 10;
                        iQue = temp % 10;
                        break;
                   case 2:
                        temp = arr[i] / 10;
                        iQue = temp % 10;
                        break;
                   case 3: ...     
                }
                */
                que[iQue].Enqueue(arr[i]);
            }

            // Bước 2
            i = 0;
            for (iQue = 0; iQue <= 9; iQue++)
            {
                while (que[iQue].Count > 0)
                {
                    arr[i] = Int32.Parse(que[iQue].Dequeue().ToString());
                    i++;
                }
            }
        }

        static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int FindMaxValue(int[] arr)
        {
            int maxtempt = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxtempt)
                    maxtempt = arr[i];
            }
            return maxtempt;
        }

        static byte DemSoChuSo(long num)
        {
            byte sochuso = 0;
            while (num > 0)
            {
                sochuso++;
                num /= 10;
            }
            return sochuso;
        }

        static void RadixSort(int[] arr)
        {
            int max = FindMaxValue(arr);
            byte sochuso = DemSoChuSo(max);
            for (byte i = 0; i < sochuso; i++)
            {
                RSPass(i, arr);
                Console.Write($"\nDãy sau chuyến {i + 1}:\t ");
                DisplayArray(arr);
            }
        }
    }
}
