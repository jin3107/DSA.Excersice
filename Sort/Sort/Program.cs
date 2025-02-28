using System;
using System.Text;

namespace Sort
{
    class Program
    {
        static void Main()
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

            ProcessSort sorter = new ProcessSort(manager.Students);
            switch (sortChoice)
            {
                case 1:
                    sorter.InterchangeSortAscending();
                    break;
                case 2:
                    sorter.InterchangeSortDescending();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            manager.HienThiDanhSach();
        }
    }
}
