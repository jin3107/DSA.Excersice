using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nChọn cách nhập điểm:");
            Console.WriteLine("1. Nhập từ bàn phím");
            Console.WriteLine("2. Khởi tạo giá trị có sẵn");
            Console.WriteLine("3. Đọc từ file");
            Console.WriteLine("4. Phát sinh ngẫu nhiên");
            Console.Write("Lựa chọn: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
                return;
            }

            int N = 0;
            if (choice == 1 || choice == 4)
            {
                Console.Write("\nNhập số lượng sinh viên: ");
                if (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
                {
                    Console.WriteLine("Số lượng sinh viên không hợp lệ!");
                    return;
                }
            }

            Service manager;
            if (choice == 3)
            {
                manager = new Service(N);
            }
            else
            {
                manager = new Service(N);
            }

            switch (choice)
            {
                case 1: manager.NhapTuBanPhim(N); break;
                case 2: manager.KhoiTaoGiaTri(); break;
                case 3: manager.NhapTuFile(); break;
                case 4: manager.DauVaoNgauNhien(N); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); return;
            }

            Console.WriteLine("\n-- Chọn cách sắp xếp --");
            Console.WriteLine("1. Sắp xếp tăng dần");
            Console.WriteLine("2. Sắp xếp giảm dần");
            Console.Write("Lựa chọn: ");

            if (!int.TryParse(Console.ReadLine(), out int sortChoice))
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
                return;
            }

            Console.WriteLine("\n-- Chọn thuật toán sắp xếp --");
            Console.WriteLine("1. Interchange Sort");
            Console.WriteLine("2. Bubble Sort");
            Console.WriteLine("3. Shaker Sort");
            Console.WriteLine("4. Selection Sort");
            Console.WriteLine("5. Quick Sort");
            Console.Write("Lựa chọn: ");

            if (!int.TryParse(Console.ReadLine(), out int algorithmChoice))
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
                return;
            }

            ProcessSort sorter = new ProcessSort(manager.Students);
            switch (sortChoice)
            {
                case 1:
                    if (algorithmChoice == 1)
                        sorter.InterchangeSortAscending();
                    else if (algorithmChoice == 2)
                        sorter.BullbleSortAscending();
                    else if (algorithmChoice == 3)
                        sorter.ShakerSortAscending();
                    else if (algorithmChoice == 4)
                        sorter.SelectionSortAscending();
                    else if (algorithmChoice == 5)
                        sorter.QuickSortAscending(0, manager.Students.Count - 1);
                    else
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        return;
                    }
                    break;
                case 2:
                    if (algorithmChoice == 1)
                        sorter.InterchangeSortDescending();
                    else if (algorithmChoice == 2)
                        sorter.BullbleSortDescending();
                    else if (algorithmChoice == 3)
                        sorter.ShakerSortDescending();
                    else if (algorithmChoice == 4)
                        sorter.SelectionSortDescending();
                    else if (algorithmChoice == 5)
                        sorter.QuickSortDescending(0, manager.Students.Count - 1);
                    else
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            manager.HienThiDanhSach();
        }
    }
}
