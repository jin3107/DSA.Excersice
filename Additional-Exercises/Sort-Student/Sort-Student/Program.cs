using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sort_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Sort sorter = new Sort();
            sorter.students = NhapDanhSachSinhVien();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n===== MENU SẮP XẾP =====");
                Console.WriteLine("1. Sắp xếp theo họ tên (Selection Sort)");
                Console.WriteLine("2. Sắp xếp theo mã sinh viên (Bubble Sort)");
                Console.WriteLine("3. Sắp xếp theo điểm trung bình (Quick Sort)");
                Console.WriteLine("4. Đếm số lượng sinh viên theo ngành");
                Console.WriteLine("5. Xuất danh sách sinh viên");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                string choice = Console.ReadLine()!;

                Console.Clear();
                switch (choice)
                {
                    case "1":
                        if (CheckEmpty(sorter.students)) break;
                        MeasureTime("Sắp xếp theo Họ tên", sorter.SelectionSortHoTen);
                        XuatDanhSachSinhVien(sorter.students);
                        break;
                    case "2":
                        if (CheckEmpty(sorter.students)) break;
                        MeasureTime("Sắp xếp theo Mã sinh viên", sorter.BubbleSortMaSV);
                        XuatDanhSachSinhVien(sorter.students);
                        break;
                    case "3":
                        if (CheckEmpty(sorter.students)) break;
                        MeasureTime("Sắp xếp theo Điểm trung bình", () => sorter.QuickSortRecursiveDTB(0, sorter.students.Count - 1));
                        XuatDanhSachSinhVien(sorter.students);
                        break;
                    case "4":
                        if (CheckEmpty(sorter.students)) break;
                        CountStudentsByField(sorter.students);
                        break;
                    case "5":
                        if (CheckEmpty(sorter.students)) break;
                        XuatDanhSachSinhVien(sorter.students);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("❌ Lựa chọn không hợp lệ! Vui lòng nhập lại.");
                        break;
                }
                Console.Write("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }

        static List<Student> NhapDanhSachSinhVien()
        {
            List<Student> students = new List<Student>();
            Console.Write("Nhập số lượng sinh viên: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("❌ Số lượng sinh viên không hợp lệ!");
                return students;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin sinh viên {i + 1}:");
                Student sv = new Student("", "", 0, "");
                sv.Nhap();
                students.Add(sv);
            }

            return students;
        }

        static void XuatDanhSachSinhVien(List<Student> students)
        {
            Console.WriteLine("\n===== DANH SÁCH SINH VIÊN =====");
            int stt = 1;
            foreach (var sv in students)
            {
                Console.WriteLine($"- Sinh viên thứ {stt++} -");
                sv.Xuat();
            }
        }

        static void MeasureTime(string algorithm, Action sortMethod)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sortMethod();
            stopwatch.Stop();
            Console.WriteLine($"{algorithm} chạy trong {stopwatch.ElapsedMilliseconds} ms\n");
        }

        static void CountStudentsByField(List<Student> students)
        {
            var counts = new Dictionary<string, int>();

            foreach (var student in students)
            {
                if (counts.ContainsKey(student.NganhHoc))
                    counts[student.NganhHoc]++;
                else
                    counts[student.NganhHoc] = 1;
            }

            Console.WriteLine("\n===== SỐ LƯỢNG SINH VIÊN THEO NGÀNH =====");
            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} sinh viên");
            }
        }

        static bool CheckEmpty(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("⚠️ Danh sách sinh viên đang rỗng! Hãy nhập dữ liệu trước.");
                return true;
            }
            return false;
        }
    }
}
