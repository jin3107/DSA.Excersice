using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS1
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
            MaSinhVien = Console.ReadLine();

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập điểm trung bình: ");
            DiemTrungBinh = double.Parse(Console.ReadLine());

            Console.Write("Nhập ngành học: ");
            NganhHoc = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("+------------+----------------------+---------+------------+");
            Console.WriteLine("| Mã SV      | Họ tên               | Điểm TB | Ngành học  |");
            Console.WriteLine("+------------+----------------------+---------+------------+");
            Console.WriteLine($"| {MaSinhVien,-10} | {HoTen,-20} | {DiemTrungBinh,-7:F2} | {NganhHoc,-10} |");
            Console.WriteLine("+------------+----------------------+---------+------------+\n");
        }
    }
}
