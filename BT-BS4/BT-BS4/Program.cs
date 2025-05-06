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

            int choice, X, V, Q;
            LinkedList linkedList = new LinkedList();
            int[] arr = { 15, 81, 4, 76, 4, 5, 90, 3 };
            //int[] arr = { 1, 3, 5, 7 };
            //int[] arr = { };
            foreach (var item in arr)
            {
                linkedList.AddXLast(item);
            }

            while (true)
            {
                Console.Clear();
                Console.Write("\n\nMảng hiện tại: ");
                linkedList.PrintList();

                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t--- *** MENU *** ---");
                Console.WriteLine("1. Duyệt và xuất các nút của ds ra màn hình");
                Console.WriteLine("2. Thêm giá trị X vào sau giá V");
                Console.WriteLine("3. Thêm giá trị X vào trước nút V");
                Console.WriteLine("4. Thêm giá trị X vào đầu danh sách");
                Console.WriteLine("5. Thêm giá trị X vào cuối danh sách");
                Console.WriteLine("6. Thêm giá trị X vào trước giá trị chẵn sau cùng trong danh sách");
                Console.WriteLine("7. Thêm giá trị X vào sau giá trị chẵn sau cùng trong danh sách");
                Console.WriteLine("8. Thêm giá trị X vào trước giá trị chẵn đầu tiên trong danh sách");
                Console.WriteLine("9. Thêm giá trị X vào sau giá trị chẵn đầu tiên trong danh sách");
                Console.WriteLine("10. Thêm giá trị X vào trước giá trị lẻ sau cùng trong danh sách");
                Console.WriteLine("11. Thêm giá trị X vào sau giá trị lẻ sau cùng trong danh sách");
                Console.WriteLine("12. Thêm giá trị X vào trước giá trị lẻ đầu tiên trong danh sách");
                Console.WriteLine("13. Thêm giá trị X vào sau giá trị lẻ đầu tiên trong danh sách");
                Console.WriteLine("14. Thêm giá trị X vào trước giá trị nhỏ nhất sau cùng trong danh sách");
                Console.WriteLine("15. Thêm giá trị X vào sau giá trị nhỏ nhất sau cùng trong danh sách");
                Console.WriteLine("16. Thêm giá trị X vào trước giá trị nhỏ nhất đầu tiên trong danh sách");
                Console.WriteLine("17. Thêm giá trị X vào sau giá trị nhỏ nhất đầu tiên trong danh sách");
                Console.WriteLine("18. Thêm giá trị X vào trước giá trị lớn nhất sau cùng trong danh sách");
                Console.WriteLine("19. Thêm giá trị X vào sau giá trị lớn nhất sau cùng trong danh sách");
                Console.WriteLine("20. Thêm giá trị X vào trước giá trị lớn nhất đầu tiên trong danh sách");
                Console.WriteLine("21. Thêm giá trị X vào sau giá trị lớn nhất đầu tiên trong danh sách");
                Console.WriteLine("22. Xóa giá trị X trong danh sách");
                Console.WriteLine("23. Xóa hết tất cả các phần tử trong danh sách");
                Console.WriteLine("24. Xóa phần tử kề sau phần tử Q trong danh sách");
                Console.WriteLine("25. Xóa phần tử kề trước phần tử Q trong danh sách");
                Console.WriteLine("26. Xóa phần tử đầu tiên trong danh sách");
                Console.WriteLine("27. Xóa phần tử cuối cùng trong danh sách");
                Console.WriteLine("28. Xóa phần tử ở giữa trong danh sách");
                Console.WriteLine("29. Xóa phần tử chẵn đầu tiên trong danh sách");
                Console.WriteLine("30. Xóa phần tử chẵn cuối cùng trong danh sách");
                Console.WriteLine("31. Xóa phần tử lẻ đầu tiên trong danh sách");
                Console.WriteLine("32. Xóa phần tử lẻ cuối cùng trong danh sách");
                Console.WriteLine("33. Xóa phần tử nhỏ nhất trong danh sách");
                Console.WriteLine("34. Xóa phần tử nhỏ nhất đầu tiên trong danh sách");
                Console.WriteLine("35. Xóa phần tử nhỏ nhất sau cùng trong danh sách");
                Console.WriteLine("36. Xóa phần tử lớn nhất trong danh sách");
                Console.WriteLine("37. Xóa phần tử lớn nhất đầu tiên trong danh sách");
                Console.WriteLine("38. Xóa phần tử lớn nhất sau cùng trong danh sách");
                Console.WriteLine("39. Tìm phần tử nhỏ nhất trong danh sách");
                Console.WriteLine("40. Tìm phần tử nhỏ nhất sau cùng trong danh sách");
                Console.WriteLine("41. Tìm phần tử nhỏ nhất đầu tiên trong danh sách");
                Console.WriteLine("42. Tìm phần tử lớn nhất trong danh sách");
                Console.WriteLine("43. Tìm phần tử lớn nhất sau cùng trong danh sách");
                Console.WriteLine("44. Tìm phần tử lớn nhất đầu tiên trong danh sách");
                Console.WriteLine("45. Tìm phần tử là số nguyên tố trong danh sách");


                Console.WriteLine("0. Thoát chương trình");
                try
                {
                    Console.Write("Lựa chọn: ");
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Lỗi nhập dữ liệu. Nhấn phím bất kỳ để thử lại...");
                    Console.ReadKey();
                    continue;
                }
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
                    
                    case 7:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXAfterEvenLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào sau giá trị chẵn sau cùng trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 8:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXBeforeEvenFirst(X);
                        Console.WriteLine($"\nĐã thêm {X} vào trước giá trị chẵn đầu tiên trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 9:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXAfterEvenFirst(X);
                        Console.WriteLine($"\nĐã thêm {X} vào sau giá trị chẵn đầu tiên trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 10:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXBeforeOddLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào trước giá trị lẻ sau cùng trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 11:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXAfterOddLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào sau giá trị lẻ sau cùng trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 12:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXBeforeOddFirst(X);
                        Console.WriteLine($"\nĐã thêm {X} vào trước giá trị lẻ đầu tiên trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 13:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXAfterOddFirst(X);
                        Console.WriteLine($"\nĐã thêm {X} vào sau giá trị lẻ đầu tiên trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 14:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXBeforeMinLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào trước giá trị nhỏ nhất sau cùng trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 15:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXAfterMinLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào sau giá trị nhỏ nhất sau cùng trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 16:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXAfterMinLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào trước giá trị nhỏ nhất đầu tiên trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 17:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXAfterMinFirst(X);
                        Console.WriteLine($"\nĐã thêm {X} vào sau giá trị nhỏ nhất đầu tiên trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 18:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXBeforeMaxLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào trước giá trị lớn nhất sau cùng trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 19:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXAfterMaxLast(X);
                        Console.WriteLine($"\nĐã thêm {X} vào sau giá trị lớn nhất sau cùng trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 20:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXBeforeMaxFirst(X);
                        Console.WriteLine($"\nĐã thêm {X} vào trước giá trị lớn nhất đầu tiên trong danh sách");
                        linkedList.PrintList();
                        break;
                    
                    case 21:
                        Console.Write("Nhập giá trị X cần thêm: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.AddXAfterMaxFirst(X);
                        Console.WriteLine($"\nĐã thêm {X} vào sau giá trị lớn nhất đầu tiên trong danh sách");
                        linkedList.PrintList();
                        break;

                    case 22:
                        Console.Write("Nhập giá trị X cần xóa: ");
                        X = int.Parse(Console.ReadLine());
                        linkedList.Remove(X);
                        linkedList.PrintList();
                        break;

                    case 23:
                        linkedList.RemoveAll();
                        linkedList.PrintList(); 
                        break;

                    case 24:
                        Console.Write("Nhập giá trị Q để xóa các phần tử kề sau: ");
                        Q = int.Parse(Console.ReadLine());
                        linkedList.RemoveAfter(Q);
                        linkedList.PrintList();
                        break;
                    
                    case 25:
                        Console.Write("Nhập giá trị Q để xóa các phần tử kề trước: ");
                        Q = int.Parse(Console.ReadLine());
                        linkedList.RemoveBefore(Q);
                        linkedList.PrintList();
                        break;

                    case 26:
                        linkedList.RemoveFirst(); 
                        linkedList.PrintList(); 
                        break;

                    case 27:
                        linkedList.RemoveLast();
                        linkedList.PrintList();
                        break;

                    case 28:
                        linkedList.RemoveCenter();
                        linkedList.PrintList();
                        break;

                    case 29:
                        linkedList.RemoveEvenFirst();
                        linkedList.PrintList();
                        break;

                    case 30:
                        linkedList.RemoveEvenLast();
                        linkedList.PrintList();
                        break;

                    case 31:
                        linkedList.RemoveOddFirst();
                        linkedList.PrintList();
                        break;

                    case 32:
                        linkedList.RemoveOddLast();
                        linkedList.PrintList();
                        break;

                    case 33:
                        linkedList.RemoveMin();
                        linkedList.PrintList();
                        break;

                    case 34: 
                        linkedList.RemoveMinFirst();
                        linkedList.PrintList();
                        break;

                    case 35: 
                        linkedList.RemoveMinLast();
                        linkedList.PrintList();
                        break;

                    case 36:
                        linkedList.RemoveMax();
                        linkedList.PrintList();
                        break;

                    case 37: 
                        linkedList.RemoveMaxFirst();
                        linkedList.PrintList();
                        break;

                    case 38: 
                        linkedList.RemoveMaxLast();
                        linkedList.PrintList();
                        break;

                    case 39:
                        linkedList.FindMin();
                        break;

                    case 40:
                        linkedList.FindLastMin();
                        break;

                    case 41:
                        linkedList.FindFirstMin();
                        break;

                    case 42:
                        linkedList.FindMax();
                        break;

                    case 43:
                        linkedList.FindLastMax();
                        break;

                    case 44: 
                        linkedList.FindFirstMax();
                        break;

                    case 45:
                        linkedList.FindPrime(); 
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
