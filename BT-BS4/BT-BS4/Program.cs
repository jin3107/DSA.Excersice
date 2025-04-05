using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_BS4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            LinkedList<int> list = new LinkedList<int>();
            int[] arr = { 15, 81, 4, 76, 4, 5 };
            foreach (var item in arr)
            {
                list.AddLast(item);
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t--- MENU ---");
                Console.WriteLine("1. Thêm X vào sau V");
                Console.WriteLine("2. Thêm X vào trước V");
                Console.WriteLine("3. Thêm X vào đầu trong dslk");
                Console.WriteLine("4. Thêm X vào cuối trong dslk");
                Console.WriteLine("5. Thêm X vào giữa trong dslk");
                Console.WriteLine("6. Thêm X vào trước giá trị chẵn sau cùng trong dslk");
                Console.WriteLine("P. In danh sách liên kết");
                Console.WriteLine("0. Thoát");

                Console.Write("Chọn chức năng: ");
                string input = Console.ReadLine()?.Trim().ToUpper();

                Console.Clear();
                switch (input)
                {
                    case "P":
                        Console.WriteLine("Danh sách liên kết hiện tại:");
                        list.PrintList();
                        break;

                    case "0":
                        return;

                    case "1":
                        Console.Write("Nhập giá trị V: ");
                        if (!int.TryParse(Console.ReadLine(), out int v))
                        {
                            Console.WriteLine("Giá trị V không hợp lệ!");
                            break;
                        }
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x1))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        if (list.AddAfter(v, x1) == null)
                            Console.WriteLine("Không tìm thấy giá trị V trong danh sách.");
                        else
                        {
                            Console.WriteLine($"Đã thêm {x1} vào sau {v}.");
                            list.PrintList();
                        }
                        break;

                    case "2":
                        Console.Write("Nhập giá trị V: ");
                        if (!int.TryParse(Console.ReadLine(), out int v2))
                        {
                            Console.WriteLine("Giá trị V không hợp lệ!");
                            break;
                        }
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x2))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        if (list.AddBefore(v2, x2) == null)
                            Console.WriteLine("Không tìm thấy giá trị V trong danh sách.");
                        else
                        {
                            Console.WriteLine($"Đã thêm {x2} vào trước {v2}.");
                            list.PrintList();
                        }
                        break;

                    case "3":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x3))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddFirst(x3);
                        list.PrintList();
                        break;

                    case "4":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x4))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddLast(x4);
                        list.PrintList();
                        break;

                    case "5":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x5))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddCenter(x5);
                        list.PrintList();
                        break;

                    case "6":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x6))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddBeforeEvenLast(x6);
                        list.PrintList();
                        break;

                    default:
                        Console.WriteLine("Chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }

                Console.Write("\nNhấn phím bất kỳ để tiếp tục ...");
                Console.ReadKey();
            }
        }
    }
}
