using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_tr24
{
    public class Handlers
    {
        public int[] NhapMang(int n)
        {
            int[] arr = new int[n];
            Console.WriteLine("Nhập các phần tử của mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        public int[] SinhMangNgauNhien(int n, int minValue = 0, int maxValue = 100)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(minValue, maxValue);
            }
            return arr;
        }

        public void XuatMang(int[] arr)
        {
            Console.WriteLine("Mảng hiện tại: " + string.Join(", ", arr));
        }
    }
}
