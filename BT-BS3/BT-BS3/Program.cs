using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Sort sort = new Sort();
            int[] arr = { 45, 23, 78, 67, 12, 88, 34, 56, 92, 34 };
            Console.WriteLine("Mảng trước khi sắp xếp: ");
            PrintArray(arr);
            Console.WriteLine();

            if (MangTangDan(arr))
                Console.WriteLine("\nMảng đã sắp xếp tăng dần");
            else
                sort.HeapSort(arr, arr.Length);

            Console.WriteLine("\nMảng sau khi sắp xếp: ");
            PrintArray(arr);
        }

        static bool MangTangDan(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
