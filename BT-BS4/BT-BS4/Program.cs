using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int choice, X, V;
            LinkedList linkedList = new LinkedList();
            int[] arr = { 15, 81, 4, 76, 4, 5, 90 };
            foreach (var item in arr)
            {
                linkedList.AddXLast(item);
            }

            while (true)
            {
                Console.Clear();
                Console.Write("Mảng hiện tại: ");
                linkedList.PrintList();

                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t--- *** MENU *** ---");
                Console.WriteLine("1. Duyệt và xuất các nút của ds ra màn hình");
                Console.WriteLine("2. Thêm giá trị X vào sau giá V");
                Console.WriteLine("3. Thêm giá trị X vào trước nút V");
                Console.WriteLine("4. Thêm giá trị X vào đầu danh sách");
                Console.WriteLine("5. Thêm giá trị X vào cuối danh sách");
                Console.WriteLine("6. Thêm giá trị X vào trước giá trị chẵn sau cùng trong danh sách");



                Console.WriteLine("0. Thoát chương trình");

                Console.Write("Lựa chọn: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 0:
                        return;

                    case 1:
                        linkedList.PrintList();
                        break;

                    case 2:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        Console.Write("Nhập giá trị V cần tìm: ");
                        V = int.Parse(Console.ReadLine());
                        if (linkedList.AddXAfterV(X, V) == null)
                            Console.WriteLine($"Không tìm thấy nút {V} trong ds");
                        else
                        {
                            Console.WriteLine($"\nĐã thêm {X} vào sau {V}");
                            linkedList.PrintList();
                        }
                        break;
                    
                    case 3:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        Console.Write("Nhập giá V cần tìm: ");
                        V = int.Parse(Console.ReadLine());
                        if (linkedList.AddXBeforeV(X, V) == null)
                            Console.WriteLine($"Không tìm thấy nút {V} trong ds");
                        else
                        {
                            Console.WriteLine($"\nĐã thêm {X} vào trước {V}");
                            linkedList.PrintList();
                        }
                        break;

                    case 4:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXFirst(X);
                        Console.WriteLine($"\nĐã thêm {X} vào đầu danh sách");
                        linkedList.PrintList();
                        break;

                    case 5:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào cuối danh sách");
                        linkedList.PrintList();
                        break;

                    case 6:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXBeforeEvenLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào trước giá trị chẵn sau cùng trong danh sách");
                        linkedList.PrintList();
                        break;


                    default:
                        Console.WriteLine("Không hợp lệ.");
                        break;
                }

                Console.WriteLine("\n\n\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }
    }
}
