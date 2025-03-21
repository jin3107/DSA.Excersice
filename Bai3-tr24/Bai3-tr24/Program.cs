using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_tr24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Handlers handlers = new Handlers();
            Console.Write("\nNhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Bạn muốn nhập mảng (1) hay sinh mảng ngẫu nhiên (2)? ");
            int choice = int.Parse(Console.ReadLine());
            int[] arr = choice == 1 ? handlers.NhapMang(n) : handlers.SinhMangNgauNhien(n);

            handlers.XuatMang(arr);
            ProcessSort sort = new ProcessSort();
            while (true)
            {
                Console.WriteLine("\n--- Câu hỏi Bài 3 ---");
                Console.WriteLine("1. Nổi bọt với cách duyệt đưa phần tử lớn nhất về cuối mảng (Duyệt Xuôi)");
                Console.WriteLine("2. Nổi bọt với cách duyệt đưa phần tử lớn nhất về đầu mảng (Duyệt Xuôi)");
                Console.WriteLine("3. Sắp xếp chọn với cách duyệt đưa phần tử lớn nhất về cuối mảng (Duyệt Xuôi)");
                Console.WriteLine("4. Sắp xếp chọn với cách duyệt đưa phần tử lớn nhất về đầu mảng (Duyệt Xuôi)");
                Console.WriteLine("5. Sắp xếp chèn với cách duyệt xem phần tử cuối mảng là dãy đã sắp xếp ban đầu (Duyệt Ngược - Tăng dần)");
                Console.WriteLine("6. Sắp xếp chèn với cách duyệt xem phần tử đầu mảng là dãy đã sắp xếp ban đầu (Duyệt Xuôi - Tăng dần)");
                Console.WriteLine("7. Sắp xếp nhanh, trong đó phân hoạch dùng phương pháp đệ quy (Tăng dần)");
                Console.WriteLine("8. Sắp xếp nhanh, trong đó phân hoạch dùng phương pháp lặp (Tăng dần)");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("Nhập lựa chọn: ");

                if (!int.TryParse(Console.ReadLine(), out int chon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập số.");
                    continue;
                }
                Console.WriteLine("\n");

                switch (chon)
                {
                    case 1:
                        sort.BubbleSortAscending(arr, n); break;
                    case 2:
                        sort.BubbleSortDescending(arr, n); break;
                    case 3:
                        sort.SelectionSortAscending(arr, n); break;
                    case 4:
                        sort.SelectionSortDescending(arr, n); break;
                    case 5:
                        sort.InsertionSortFromEnd(arr, n); break;
                    case 6:
                        sort.InsertionSortFromBeginning(arr, n); break;
                    case 7:
                        sort.QuickSortRecursiveAscending_DuyetXuoi(arr, 0, n - 1); break;
                    case 8:
                        sort.QuickSortIterativeAscending_DuyetXuoi(arr, 0, n - 1); break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("\nLựa chọn không hợp lệ.");
                        break;
                }
                Console.WriteLine("\nMảng sau khi sắp xếp:");
                handlers.XuatMang(arr);
            }
        }
    }
}
