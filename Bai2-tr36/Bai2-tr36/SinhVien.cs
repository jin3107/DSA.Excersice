using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_tr36
{
    public class SinhVien
    {
        public string maSinhVien { get; set; }
        public string hoTen { get; set; }
        public double diem { get; set; }

        public SinhVien(string maSinhVien, string hoTen, double diem)
        {
            this.maSinhVien = maSinhVien;
            this.hoTen = hoTen;
            this.diem = diem;
        }

        public void Nhap()
        {
            Console.Write("Nhập mã sinh viên: ");
            maSinhVien = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập điểm: ");
            diem = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"MSSV: {maSinhVien}, Họ tên: {hoTen}, Điểm: {diem}";
        }
    }
}
