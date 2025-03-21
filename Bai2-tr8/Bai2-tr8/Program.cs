using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_tr8
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
                Console.Write("Nhập số lượng sinh viên: ");
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
                case 4: manager.DauVaoNgauNhien(); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); return;
            }

            manager.DoLuongHieuSuat();
        }
    }
}
