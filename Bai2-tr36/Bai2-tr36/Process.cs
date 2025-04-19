using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Bai2_tr36
{

    public class Process
    {
        public LinkedList<SinhVien> dsSinhVien { get; set; } = new LinkedList<SinhVien>();

        // Nhập thông tin sinh viên
        public void NhapSinhVien()
        {
            int n;
            Console.Write("Nhập số lượng sinh viên: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                SinhVien sv = new SinhVien("", "", 0);
                sv.Nhap();
                dsSinhVien.AddLast(sv);
                Console.WriteLine();
            }
        }

        // Sửa thông tin sinh viên
        public void SuaSinhVien()
        {
            Console.Write("Nhập mã sinh viên cần sửa: ");
            string maSV = Console.ReadLine();
            foreach (var sv in dsSinhVien)
            {
                if (sv.maSinhVien == maSV)
                {
                    Console.WriteLine("Thông tin sinh viên cũ: " + sv.ToString());
                    sv.Nhap();
                    Console.WriteLine("Thông tin sinh viên sau khi sửa: " + sv.ToString());
                    break;
                }
            }
        }

        // Xóa thông tin sinh viên
        public void XoaSinhVien()
        {
            Console.Write("Nhập mã sinh viên cần xóa: ");
            string maSV = Console.ReadLine();
            foreach (var sv in dsSinhVien)
            {
                if (sv.maSinhVien == maSV)
                {
                    dsSinhVien.Remove(sv);
                    Console.WriteLine("Đã xóa thông tin sinh viên có mã " + maSV);
                    break;
                }
            }
        }

        // Xem danh sách sinh viên (theo thứ tự nhập)
        public void XemDanhSachSinhVien()
        {
            if (dsSinhVien.Count == 0)
                Console.WriteLine("Danh sách rỗng");
            else
            {
                Console.WriteLine("Danh sách sinh viên:");
                foreach (var sv in dsSinhVien)
                {
                    Console.WriteLine(sv.ToString());
                }
            }
        }

        // Xem danh sách sinh viên (theo thứ tự tăng của mã sinh viên)
        public void XemDanhSachSinhVienTheoMa()
        {
            if (dsSinhVien.Count == 0)
                Console.WriteLine("Danh sách rỗng");
            else
            {
                Console.WriteLine("Danh sách sinh viên theo thứ tự tăng dần của mã sinh viên:");
                var sortedList = new List<SinhVien>(dsSinhVien);
                sortedList.Sort((x, y) => x.maSinhVien.CompareTo(y.maSinhVien));
                foreach (var sv in sortedList)
                {
                    Console.WriteLine(sv.ToString());
                }
            }
        }

        // Tìm sinh viên có điểm cao nhất
        public void TimSinhVienDiemCaoNhat()
        {
            if (dsSinhVien.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên rỗng.");
                return;
            }

            double maxDiem = double.MinValue;
            foreach (var sv in dsSinhVien)
            {
                if (sv.diem > maxDiem)
                    maxDiem = sv.diem;
            }

            Console.WriteLine("Danh sách sinh viên có điểm cao nhất:");
            foreach (var sv in dsSinhVien)
            {
                if (sv.diem == maxDiem)
                {
                    Console.WriteLine(sv.ToString());
                }
            }
        }

        // Tìm sinh viên theo mã sinh viên
        public void TimSinhVien()
        {
            Console.Write("Nhập mã sinh viên cần tìm: ");
            string maSV = Console.ReadLine();
            foreach (var sv in dsSinhVien)
            {
                if (sv.maSinhVien == maSV)
                {
                    Console.WriteLine("Thông tin sinh viên tìm thấy: " + sv.ToString());
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy sinh viên có mã " + maSV);
        }

        // Tính điểm trung bình tất cả sinh viên
        public void DiemTrungBinhSinhVien()
        {
            double tongDiem = 0;
            int count = 0;
            foreach (var sv in dsSinhVien)
            {
                tongDiem += sv.diem;
                count++;
            }
            if (count > 0)
                Console.WriteLine("Điểm trung bình của tất cả sinh viên: " + (tongDiem / count));
            else
                Console.WriteLine("Danh sách sinh viên rỗng.");
        }

        // Đếm số lượng sinh viên trong danh sách
        public void DemSinhVien()
        {
            if (dsSinhVien.Count == 0)
                Console.WriteLine("Danh sách rỗng\n");
            else
                Console.WriteLine(dsSinhVien.Count.ToString());
        }
    }
} 
