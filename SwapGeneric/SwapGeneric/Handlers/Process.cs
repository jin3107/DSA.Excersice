using SwapGeneric.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapGeneric.Handlers
{
    public static class Process
    {
        public static void SwapIntegers()
        {
            int a = Input.GetInput<int>("Nhập giá trị int a: ");
            int b = Input.GetInput<int>("Nhập giá trị int b: ");
            Generic.Swap(ref a, ref b);
            Console.WriteLine($"Đã hoán vị 2 giá trị kiểu 'int': a = {a}; b = {b}\n");
        }

        public static void SwapDoubles()
        {
            double x = Input.GetInput<double>("Nhập giá trị double x: ");
            double y = Input.GetInput<double>("Nhập giá trị double y: ");
            Generic.Swap(ref x, ref y);
            Console.WriteLine($"Đã hoán vị 2 giá trị kiểu 'double': x = {x}; y = {y}\n");
        }

        public static void SwapStrings()
        {
            string s1 = Input.GetInput<string>("Nhập chuỗi s1: ");
            string s2 = Input.GetInput<string>("Nhập chuỗi s2: ");
            Generic.Swap(ref s1, ref s2);
            Console.WriteLine($"Đã hoán vị 2 giá trị kiểu 'string': s1 = {s1}; s2 = {s2}\n");
        }

        public static void SwapNhanVien()
        {
            NhanVien nv1 = new NhanVien
            (
                Input.GetInput<string>("Nhập tên nhân viên 1: "),
                Input.GetInput<int>("Nhập mã nhân viên 1: "),
                Input.GetInput<double>("Nhập hệ số lương nhân viên 1: ")
            );
            Console.WriteLine("\n");
            NhanVien nv2 = new NhanVien
            (
                Input.GetInput<string>("Nhập tên nhân viên 2: "),
                Input.GetInput<int>("Nhập mã nhân viên 2: "),
                Input.GetInput<double>("Nhập hệ số lương nhân viên 2: ")
            );
            Generic.Swap(ref nv1, ref nv2);
            Console.WriteLine($"Đã hoán vị Nhân Viên:\n  NV1: {nv1}\n  NV2: {nv2}");
        }

        public static void SwapSinhVien()
        {
            SinhVien sv1 = new SinhVien
            (
                Input.GetInput<string>("Nhập tên sinh  viên 1: "),
                Input.GetInput<int>("Nhập mã sinh viên 1: "),
                Input.GetInput<double>("Nhập ĐTB sinh viên 1: ")
            );
            Console.WriteLine("\n");
            SinhVien sv2 = new SinhVien
            (
                Input.GetInput<string>("Nhập tên sinh viên 2: "),
                Input.GetInput<int>("Nhập mã sinh viên 2: "),
                Input.GetInput<double>("Nhập ĐTB sinh viên 2: ")
            );
            Generic.Swap(ref sv1, ref sv2);
            Console.WriteLine($"Đã hoán vị Sinh Viên:\n  SV1: {sv1}\n  SV2: {sv2}");
        }
    }
}
