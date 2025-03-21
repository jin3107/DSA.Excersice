using Bai3_tr9.ThaoTac;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_tr9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.InputEncoding = System.Text.Encoding.UTF8;
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("=== CHƯƠNG TRÌNH HOÁN VỊ ===");
                Console.WriteLine("1. Hoán vị số nguyên (chỉ nhận số dương)");
                Console.WriteLine("2. Hoán vị số thực (chỉ nhận số dương)");
                Console.WriteLine("3. Hoán vị chuỗi (không để trống)");
                Console.WriteLine("4. Hoán vị Nhân Viên");
                Console.WriteLine("5. Hoán vị Sinh Viên");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        QuaTrinh.SwapIntegers();
                        break;
                    case "2":
                        QuaTrinh.SwapDoubles();
                        break;
                    case "3":
                        QuaTrinh.SwapStrings();
                        break;
                    case "4":
                        QuaTrinh.SwapNhanVien();
                        break;
                    case "5":
                        QuaTrinh.SwapSinhVien();
                        break;
                    case "0":
                        Console.WriteLine("Thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("❌ Lựa chọn không hợp lệ, vui lòng nhập lại.");
                        break;
                }

                Console.WriteLine("\nNhấn Enter để tiếp tục...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
