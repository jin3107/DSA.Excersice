using System;
using System.Text;

namespace Cau3
{
    class Program
    {
        // Phương thức nhập mảng từ bàn phím
        static int[] NhapMang(int n)
        {
            int[] arr = new int[n];
            Console.WriteLine("Nhập các phần tử của mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            return arr;
        }

        // Phương thức sinh mảng ngẫu nhiên
        static int[] SinhMangNgauNhien(int n, int minValue = 0, int maxValue = 100)
        {
            Random rand = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(minValue, maxValue);
            }
            return arr;
        }

        // Phương thức xuất mảng
        static void XuatMang(int[] arr)
        {
            Console.WriteLine("Mảng hiện tại: " + string.Join(", ", arr));
        }

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("\nNhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.Write("Bạn muốn nhập mảng (1) hay sinh mảng ngẫu nhiên (2)? ");
            int choice = int.Parse(Console.ReadLine()!);
            int[] arr = choice == 1 ? NhapMang(n) : SinhMangNgauNhien(n);

            XuatMang(arr);

            Sort sorter = new Sort();

            Console.WriteLine("\nChọn thuật toán sắp xếp:");
            Console.WriteLine("1. Bubble Sort Ascending");
            Console.WriteLine("2. Bubble Sort Descending");
            Console.WriteLine("3. Selection Sort Ascending");
            Console.WriteLine("4. Selection Sort Descending");
            Console.WriteLine("5. Insertion Sort (From End)");
            Console.WriteLine("6. Insertion Sort (From Beginning)");
            //Console.WriteLine("7. Quick Sort (Recursive)");
            //Console.WriteLine("8. Quick Sort (Iterative)");
            Console.Write("Nhập lựa chọn: ");
            int option = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");

            switch (option)
            {
                case 1:
                    sorter.BubbleSortAscending(arr, n);
                    break;
                case 2:
                    sorter.BubbleSortDescending(arr, n);
                    break;
                case 3:
                    sorter.SelectionSortAscending(arr, n);
                    break;
                case 4:
                    sorter.SelectionSortDescending(arr, n);
                    break;
                case 5:
                    sorter.InsertionSortFromEnd(arr, n);
                    break;
                case 6:
                    sorter.InsertionSortFromBeginning(arr, n);
                    break;
                //case 7:
                //    sorter.QuickSortRecursive(arr, n);
                //    break;
                //case 8:
                //    sorter.QuickSortIterative(arr, n);
                //    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            Console.WriteLine("\nMảng sau khi sắp xếp:");
            XuatMang(arr);
        }
    }
}
