using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Student
{
    public class Student
    {
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public double DiemTrungBinh { get; set; }
        public string NganhHoc { get; set; }

        public Student(string maSinhVien, string hoTen, double diemTrungBinh, string nganhHoc)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            DiemTrungBinh = diemTrungBinh;
            NganhHoc = nganhHoc;
        }

        public void Nhap()
        {
            Console.Write("Nhập mã sinh viên: ");
            MaSinhVien = Console.ReadLine()!;

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine()!;

            Console.Write("Nhập điểm trung bình: ");
            DiemTrungBinh = double.Parse(Console.ReadLine()!);

            Console.Write("Nhập ngành học: ");
            NganhHoc = Console.ReadLine()!;
        }

        public void Xuat()
        {
            Console.WriteLine($"Mã sinh viên: {MaSinhVien}");
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Điểm trung bình: {DiemTrungBinh}");
            Console.WriteLine($"Ngành học: {NganhHoc}\n");
        }
    }
}
