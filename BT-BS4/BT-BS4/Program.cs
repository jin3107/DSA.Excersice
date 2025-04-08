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
                Console.WriteLine("\t\t--- *** MENU *** ---");
                Console.WriteLine("1. Thêm X vào sau V");
                Console.WriteLine("2. Thêm X vào trước V");
                Console.WriteLine("3. Thêm X vào đầu trong danh sách liên kết");
                Console.WriteLine("4. Thêm X vào cuối trong danh sách liên kết");
                Console.WriteLine("5. Thêm X vào giữa trong danh sách liên kết");
                Console.WriteLine("6. Thêm X vào trước giá trị chẵn sau cùng trong danh sách liên kết");
                Console.WriteLine("7. Thêm X vào sau giá trị chẵn sau cùng trong danh sách liên kết");
                Console.WriteLine("8. Thêm X vào trước giá trị chẵn đầu tiên trong danh sách liên kết");
                Console.WriteLine("9. Thêm X vào sau giá trị chẵn đầu tiên trong danh sách liên kết");
                Console.WriteLine("10. Thêm X vào trước giá trị lẻ sau cùng trong danh sách liên kết");
                Console.WriteLine("11. Thêm X vào sau giá trị lẻ sau cùng trong danh sách liên kết");
                Console.WriteLine("12. Thêm X vào trước giá trị lẻ đầu tiên trong danh sách liên kết");
                Console.WriteLine("13. Thêm X vào sau giá trị lẻ đầu tiên trong danh sách liên kết");
                Console.WriteLine("14. Thêm X vào trước giá trị nhỏ nhất sau cùng trong danh sách liên kết");
                Console.WriteLine("15. Thêm X vào sau giá trị nhỏ nhất sau cùng trong danh sách liên kết");
                Console.WriteLine("16. Thêm X vào trước giá trị nhỏ nhất đầu tiên trong danh sách liên kết");
                Console.WriteLine("17. Thêm X vào sau giá trị nhỏ nhất đầu tiên trong danh sách liên kết");
                Console.WriteLine("18. Thêm X vào trước giá trị lớn nhất sau cùng trong danh sách liên kết");
                Console.WriteLine("19. Thêm X vào sau giá trị lớn nhất sau cùng trong danh sách liên kết");
                Console.WriteLine("20. Thêm X vào trước giá trị lớn nhất đầu tiên trong danh sách liên kết");
                Console.WriteLine("21. Thêm X vào sau giá trị lớn nhất đầu tiên trong danh sách liên kết");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("22. Xóa X trong danh sách liên kết");
                Console.WriteLine("23. Xóa hết tất cả các phần tử trong danh sách liên kết");
                Console.WriteLine("24. Xóa phần tử kề sau phần tử Q trong danh sách liên kết");
                Console.WriteLine("25. Xóa phần tử kề trước phần tử Q trong danh sách liên kết");
                Console.WriteLine("26. Xóa phần tử đầu tiên trong danh sách liên kết");
                Console.WriteLine("27. Xóa phần tử cuối cùng trong danh sách liên kết");
                Console.WriteLine("28. Xóa phần tử ỡ giữa trong danh sách liên kết");
                Console.WriteLine("29. Xóa phần tử chẵn đầu tiên trong danh sách liên kết");
                Console.WriteLine("30. Xóa phần tử chẵn cuồi cùng trong danh sách liên kết");
                Console.WriteLine("31. Xóa phần tử lẻ đầu tiên trong danh sách liên kết");
                Console.WriteLine("32. Xóa phần tử lẻ cuồi cùng trong danh sách liên kết");
                Console.WriteLine("33. Xóa phần tử nhỏ nhất trong danh sách liên kết");
                Console.WriteLine("34. Xóa phần tử nhỏ nhất đầu tiên trong danh sách liên kết");
                Console.WriteLine("35. Xóa phần tử nhỏ nhất sau cùng trong danh sách liên kết");
                Console.WriteLine("36. Xóa phần tử lớn nhất trong danh sách liên kết");
                Console.WriteLine("37. Xóa phần tử lớn nhất đầu tiên trong danh sách liên kết");
                Console.WriteLine("38. Xóa phần tử lớn nhất sau cùng trong danh sách liên kết");
                Console.WriteLine("-------------------------------------------------------------------------");
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

                    case "7":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x7))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddAfterEvenLast(x7);
                        list.PrintList();
                        break;

                    case "8":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x8))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddBeforeEvenFirst(x8);
                        list.PrintList();
                        break;

                    case "9":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x9))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddAfterEvenFirst(x9);
                        list.PrintList();
                        break;

                    case "10":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x10))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddBeforeOddLast(x10);
                        list.PrintList();
                        break;

                    case "11":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x11))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddAfterOddLast(x11);
                        list.PrintList();
                        break;

                    case "12":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x12))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddBeforeOddFirst(x12);
                        list.PrintList();
                        break;

                    case "13":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x13))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddAfterOddFirst(x13);
                        list.PrintList();
                        break;

                    case "14":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x14))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddBeforeMinLast(x14);
                        list.PrintList();
                        break;

                    case "15":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x15))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddAfterMinLast(x15);
                        list.PrintList();
                        break;

                    case "16":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x16))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddBeforeMinFirst(x16);
                        list.PrintList();
                        break;

                    case "17":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x17))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddAfterMinFirst(x17);
                        list.PrintList();
                        break;

                    case "18":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x18))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddBeforeMaxLast(x18);
                        list.PrintList();
                        break;

                    case "19":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x19))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddAfterMaxLast(x19);
                        list.PrintList();
                        break;

                    case "20":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x20))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddBeforeMaxFirst(x20);
                        list.PrintList();
                        break;

                    case "21":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x21))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.AddAfterMaxFirst(x21);
                        list.PrintList();
                        break;

                    case "22":
                        Console.Write("Nhập giá trị X: ");
                        if (!int.TryParse(Console.ReadLine(), out int x22))
                        {
                            Console.WriteLine("Giá trị X không hợp lệ!");
                            break;
                        }
                        list.Remove(x22);
                        list.PrintList();
                        break;

                    case "23":
                        list.RemoveAll();
                        list.PrintList();
                        break;

                    case "24":
                        Console.Write("Nhập giá trị Q: ");
                        if (!int.TryParse(Console.ReadLine(), out int q1))
                        {
                            Console.WriteLine("Giá trị Q không hợp lệ!");
                            break;
                        }
                        list.RemoveAfter(q1);
                        list.PrintList();
                        break;

                    case "25":
                        Console.Write("Nhập giá trị Q: ");
                        if (!int.TryParse(Console.ReadLine(), out int q2))
                        {
                            Console.WriteLine("Giá trị Q không hợp lệ!");
                            break;
                        }
                        list.RemoveBefore(q2);
                        list.PrintList();
                        break;

                    case "26":
                        list.RemoveFirst();
                        list.PrintList();
                        break;

                    case "27":
                        list.RemoveLast();
                        list.PrintList();
                        break;

                    case "28":
                        list.RemoveCenter();
                        list.PrintList();
                        break;

                    case "29":
                        list.RemoveEvenFirst();
                        list.PrintList();
                        break;

                    case "30":
                        list.RemoveEvenLast();
                        list.PrintList();
                        break;

                    case "31":
                        list.RemoveOddFirst();
                        list.PrintList();
                        break;

                    case "32":
                        list.RemoveOddLast();
                        list.PrintList();
                        break;

                    case "33":
                        list.RemoveMin();
                        list.PrintList();
                        break;

                    case "34":
                        list.RemoveMinFirst();
                        list.PrintList();
                        break;

                    case "35":
                        list.RemoveMinLast();
                        list.PrintList();
                        break;

                    case "36":
                        list.RemoveMax();
                        list.PrintList();
                        break;

                    case "37":
                        list.RemoveMaxFirst();
                        list.PrintList();
                        break;

                    case "38":
                        list.RemoveMaxLast();
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
