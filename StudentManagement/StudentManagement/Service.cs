using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Service
    {
        public Student[] students { get; set; }

        public Service(int n)
        {
            students = new Student[n];
        }

        public void NhapTuBanPhim(int n)
        {
            students = new Student[n];
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < students.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Nhập điểm sinh viên thứ {i + 1} (M1 M2 M3): ");
                    string[] nhapDiem = Console.ReadLine()!.Split();
                    if (nhapDiem.Length != 3 || !double.TryParse(nhapDiem[0], out double m1)
                        || !double.TryParse(nhapDiem[1], out double m2) || !double.TryParse(nhapDiem[2], out double m3))
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ! Vui lòng nhập lại.");
                        continue;
                    }
                    students[i] = new Student { Id = i + 1, M1 = m1, M2 = m2, M3 = m3 };
                    break;
                }
            }
        }

        public void KhoiTaoGiaTri()
        {
            //students = new Student[]
            //{
            //    new Student { Id = 1, M1 = 8.5, M2 = 9.0, M3 = 7.8 },
            //    new Student { Id = 2, M1 = 7.6, M2 = 8.0, M3 = 8.8 },
            //    new Student { Id = 3, M1 = 9.2, M2 = 9.5, M3 = 8.9 }
            //};
            students = new Student[100];
            for (int i = 0; i < 100; i++)
            {
                students[i] = new Student
                {
                    Id = i + 1,
                    M1 = (i % 10) * 10 + 5,
                    M2 = (i % 5) * 20 + 10,
                    M3 = (i % 7) * 15 + 5
                };
            }
            Console.WriteLine(students);
        }

        public void NhapTuFile()
        {
            Console.WriteLine("\nChọn loại file để nhập:");
            Console.WriteLine("1. File .txt");
            Console.WriteLine("2. File .xlsx");
            Console.Write("Lựa chọn: ");

            if (!int.TryParse(Console.ReadLine(), out int fileChoice) || (fileChoice != 1 && fileChoice != 2))
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
                return;
            }

            if (fileChoice == 1)
            {
                try
                {
                    string[] lines = File.ReadAllLines("students.txt");
                    students = new Student[lines.Length];

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split();
                        if (parts.Length != 4 || !int.TryParse(parts[0], out int id)
                            || !double.TryParse(parts[1], out double m1) || !double.TryParse(parts[2], out double m2)
                            || !double.TryParse(parts[3], out double m3))
                        {
                            Console.WriteLine($"Dữ liệu dòng {i + 1} trong file không hợp lệ!");
                            continue;
                        }
                        students[i] = new Student { Id = id, M1 = m1, M2 = m2, M3 = m3 };
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi đọc file: " + ex.Message);
                }
            }
            else if (fileChoice == 2)
            {
                try
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (var package = new ExcelPackage(new FileInfo("students.xlsx")))
                    {
                        var worksheet = package.Workbook.Worksheets[0];
                        int rowCount = worksheet.Dimension.Rows;
                        students = new Student[rowCount - 1];

                        for (int i = 2; i <= rowCount; i++)
                        {
                            if (!int.TryParse(worksheet.Cells[i, 1].Text, out int id) ||
                                !double.TryParse(worksheet.Cells[i, 2].Text, out double m1) ||
                                !double.TryParse(worksheet.Cells[i, 3].Text, out double m2) ||
                                !double.TryParse(worksheet.Cells[i, 4].Text, out double m3))
                            {
                                Console.WriteLine($"Dữ liệu dòng {i} trong file không hợp lệ!");
                                continue;
                            }
                            students[i - 2] = new Student { Id = id, M1 = m1, M2 = m2, M3 = m3 };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi đọc file Excel: " + ex.Message);
                }
            }
        }

        public void DauVaoNgauNhien()
        {
            Random rand = new Random();
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student
                {
                    Id = i + 1,
                    M1 = rand.Next(0, 11),
                    M2 = rand.Next(0, 11),
                    M3 = rand.Next(0, 11)
                };
            }
        }

        public double TinhDTB_C1()
        {
            double sum = 0;
            foreach (var student in students)
                sum += student.Average;
            return sum / students.Length;
        }

        public double TinhDTB_C2()
        {
            double sumM1 = 0, sumM2 = 0, sumM3 = 0;
            foreach (var student in students)
            {
                sumM1 += student.M1;
                sumM2 += student.M2;
                sumM3 += student.M3;
            }
            return (sumM1 / students.Length + sumM2 / students.Length + sumM3 / students.Length) / 3;
        }

        public void DoLuongHieuSuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Stopwatch sw = new Stopwatch();
            Console.WriteLine($"\nSố lượng sinh viên: {students.Length}");

            sw.Start();
            double dtbC1 = TinhDTB_C1();
            sw.Stop();
            Console.WriteLine($"Cách 1: {sw.ElapsedMilliseconds} ms (DTB: {dtbC1:F2})");

            sw.Restart();
            double dtbC2 = TinhDTB_C2();
            sw.Stop();
            Console.WriteLine($"Cách 2: {sw.ElapsedMilliseconds} ms (DTB: {dtbC2:F2})");
        }
    }
}
