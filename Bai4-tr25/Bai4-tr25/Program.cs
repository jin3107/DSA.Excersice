using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Media.Effects;

namespace Bai4_tr25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Handler handler = new Handler();
            Search search = new Search();
            int[] arr = null;
            Console.WriteLine("Chọn cách nhập mảng:");
            Console.WriteLine("1. Nhập từ file (.txt hoặc .xlsx)");
            Console.WriteLine("2. Tạo ngẫu nhiên");
            Console.Write("Chọn: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    handler.NhapTuFile(out arr);
                    break;
                case 2:
                    Console.Write("Nhập số phần tử của mảng: ");
                    int n = int.Parse(Console.ReadLine());
                    arr = new int[n];
                    handler.DauVaoNgauNhien(arr, n);
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Mảng không hợp lệ! Thoát chương trình.");
                return;
            }

            Console.Write("\nNhập phần tử cần tìm: ");
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Giá trị không hợp lệ! Nhập lại: ");
            }
            Console.WriteLine($"\nTìm phần tử {x} trong mảng {arr.Length} phần tử...\n");
            CompareAlgorithms(search, arr, x);
        }

        static void CompareAlgorithms(Search search, int[] arr, int x)
        {
            Stopwatch sw = new Stopwatch();
            int result;

            // 4.1 Tìm nhị phân (lặp vs. đệ quy)
            Console.WriteLine("So sánh Binary Search lặp & đệ quy:");

            int[] sortedArr = (int[])arr.Clone();
            search.QuickSortIterative(sortedArr, 0, sortedArr.Length - 1);

            sw.Restart();
            result = search.BinarySearchInterative(sortedArr, sortedArr.Length, x);
            sw.Stop();
            Console.WriteLine($"BinarySearch (lặp) tìm thấy tại vị trí {result} trong {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            result = search.BinarySearchRecursive(sortedArr, 0, sortedArr.Length - 1, x);
            sw.Stop();
            Console.WriteLine($"BinarySearch (đệ quy) tìm thấy tại vị trí {result} trong {sw.ElapsedMilliseconds} ms\n");

            // 4.2 Tìm tuần tự (SeqSearch vs. IndexOf) - Giữ nguyên mảng gốc
            int[] originalArr = (int[])arr.Clone();
            Console.WriteLine("So sánh Tìm kiếm tuần tự:");

            sw.Restart();
            result = search.SeqSearch(originalArr, originalArr.Length, x);
            sw.Stop();
            Console.WriteLine($"SeqSearch tự cài tìm thấy tại vị trí {result} trong {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            result = Array.IndexOf(originalArr, x);
            sw.Stop();
            Console.WriteLine($"IndexOf (.NET) tìm thấy tại vị trí {result} trong {sw.ElapsedMilliseconds} ms\n");

            // 4.3 Tìm nhị phân (BinSearch tự cài vs. BinarySearch .NET)
            Console.WriteLine("So sánh Binary Search tự cài vs .NET:");

            sw.Restart();
            result = search.BinarySearchInterative(sortedArr, sortedArr.Length, x);
            sw.Stop();
            Console.WriteLine($"BinarySearch tự cài tìm thấy tại vị trí {result} trong {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            result = Array.BinarySearch(sortedArr, x);
            sw.Stop();
            Console.WriteLine($"BinarySearch (.NET) tìm thấy tại vị trí {result} trong {sw.ElapsedMilliseconds} ms\n");
        }
    }
}
