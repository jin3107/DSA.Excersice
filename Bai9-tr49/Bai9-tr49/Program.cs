using System;
using System.Collections.Generic;
using System.Text;

namespace Bai9_tr49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // Phần sắp xếp Radix
            Sort sort = new Sort();
            int[] arr = { 19, 133, 60, 2450, 35, 9, 638, 478 };

            Console.WriteLine("\t--- Radix Sort ---");
            Console.Write("Dãy ban đầu:\t\t");
            sort.Display(arr);
            sort.RadixSort(arr);
            Console.Write("\nDãy đã sắp xếp:\t\t");
            sort.Display(arr);
            Console.WriteLine("\n");

            // Phần quản lý kho hàng
            Console.WriteLine("\t--- Quản lý kho hàng ---");
            QuanLyKhoHang khoHang = new QuanLyKhoHang();
            List<LoHang> danhSachNhap = new List<LoHang>();

            Console.Write("Nhập số lượng lô hàng: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập lô hàng thứ {i + 1}:");
                LoHang loHang = new LoHang();
                loHang.NhapLoHang();
                danhSachNhap.Add(loHang);
            }

            khoHang.NhapKho(danhSachNhap.Count, danhSachNhap);

            Console.WriteLine("\nDanh sách trong kho:");
            khoHang.HienThiKho();
            Console.WriteLine($"Tổng số lô hàng trong kho: {khoHang.SoLuongTonKho()}");

            Console.WriteLine("\nXuất kho lô hàng đầu tiên:");
            LoHang xuatKho = khoHang.XuatKho();
            if (xuatKho != null)
                Console.WriteLine(xuatKho.ToString());
            else
                Console.WriteLine("Kho rỗng, không thể xuất.");

            Console.WriteLine($"Số lượng còn lại trong kho: {khoHang.SoLuongTonKho()}");

            Console.ReadKey();
        }
    }
}
