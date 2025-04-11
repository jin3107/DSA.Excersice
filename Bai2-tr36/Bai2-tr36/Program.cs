using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_tr36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Process process = new Process();
            LinkedList<SinhVien> dsSinhVien = new LinkedList<SinhVien>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU ---");
                Console.WriteLine("1. Nhập thông tin sinh viên");
                Console.WriteLine("2. Sửa thông tin sinh viên");
                Console.WriteLine("3. Xóa thông tin sinh viên");
                Console.WriteLine("4. Xem danh sách sinh viên theo thứ tự nhập");
                Console.WriteLine("5. Xem danh sách sinh viên theo thứ tự tăng dần của mã sinh viên");
                Console.WriteLine("6. Tìm sinh viên theo mã sinh viên có điểm cao nhất");
                Console.WriteLine("7. Tìm sinh viên theo mã sinh viên");
                Console.WriteLine("8. Tính điểm trung bình tất cả sinh viên");
                Console.WriteLine("9. Đếm số lượng sinh viên trong danh sách");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        process.NhapSinhVien();
                        break;

                    case 2:
                        process.SuaSinhVien();
                        break;

                    case 3:
                        process.XoaSinhVien();
                        break;

                    case 4:
                        process.XemDanhSachSinhVien();
                        break;

                    case 5:
                        process.XemDanhSachSinhVienTheoMa();
                        break;

                    case 6:
                        process.TimSinhVienDiemCaoNhat();
                        break;

                    case 7:
                        process.TimSinhVien();
                        break;

                    case 8:
                        process.DiemTrungBinhSinhVien();
                        break;

                    case 9:
                        process.DemSinhVien();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("\nChọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
                Console.WriteLine("\n\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }
    }
}
