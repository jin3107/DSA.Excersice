using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Bai4_tr25
{
    public class Handler
    {
        public void DauVaoNgauNhien(int[] arr, int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = random.Next(1, 100001);
        }

        public void XuatMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
        }

        public void NhapTuFile(out int[] arr)
        {
            Console.WriteLine("\nChọn loại file để nhập:");
            Console.WriteLine("1. File .txt");
            Console.WriteLine("2. File .xlsx");
            Console.Write("Chọn: ");

            if (!int.TryParse(Console.ReadLine(), out int fileChoice) || (fileChoice != 1 && fileChoice != 2))
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
                arr = new int[0];
                return;
            }

            List<int> data = new List<int>();

            if (fileChoice == 1)
            {
                try
                {
                    string[] lines = System.IO.File.ReadAllLines("input.txt");
                    foreach (var line in lines)
                    {
                        if (int.TryParse(line.Trim(), out int num))
                            data.Add(num);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi đọc file .txt: {ex.Message}");
                    arr = new int[0];
                    return;
                }
            }
            else if (fileChoice == 2)
            {
                try
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (var package = new ExcelPackage(new FileInfo("input.xlsx")))
                    {
                        var worksheet = package.Workbook.Worksheets[0];
                        int rowCount = worksheet.Dimension.Rows;
                        for (int i = 1; i <= rowCount; i++)
                        {
                            if (int.TryParse(worksheet.Cells[i, 1].Text.Trim(), out int num))
                                data.Add(num);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi đọc file .xlsx: {ex.Message}");
                    arr = new int[0];
                    return;
                }
            }
            arr = data.ToArray();
        }
    }
}
