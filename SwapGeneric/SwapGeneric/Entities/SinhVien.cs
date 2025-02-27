using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapGeneric.Entities
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public int MaSinhVien { get; set; }
        public double DiemTrungBinh { get; set; }

        public SinhVien(string hoTen, int maSinhVien, double diemTrungBinh)
        {
            HoTen = hoTen;
            MaSinhVien = maSinhVien;
            DiemTrungBinh = diemTrungBinh;
        }

        public override string ToString()
        {
            return $"Mã sinh viên: {MaSinhVien}, Họ tên: {HoTen}, DTB: {DiemTrungBinh}";
        }

    }
}
