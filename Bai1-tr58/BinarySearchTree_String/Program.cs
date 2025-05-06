using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            BinarySearchTree tree = new BinarySearchTree();
            int choice;
            string S;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Thêm nút (đệ quy)");
                Console.WriteLine("2. Thêm nút (lặp)");
                Console.WriteLine("3. Duyệt cây PreOrder");
                Console.WriteLine("4. Duyệt cây InOrder");
                Console.WriteLine("5. Duyệt cây PostOrder");
                Console.WriteLine("6. Tạo cây từ mảng");
                Console.WriteLine("7. Tạo cây từ bàn phím");
                Console.WriteLine("8. Tìm nút dài nhất");
                Console.WriteLine("9. Tìm nút ngắn nhất");

                Console.WriteLine("0. Thoát");
                Console.Write("\nChọn chức năng: ");
                choice = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập giá trị X để thêm (đệ quy): ");
                        S = Console.ReadLine();
                        if (tree.Add_DeQuy(ref tree.root, S))
                            Console.WriteLine("Đã thêm thành công.");
                        else
                            Console.WriteLine("Không thể thêm (giá trị đã tồn tại).");
                        break;

                    case 2:
                        Console.Write("Nhập giá trị X để thêm (lặp): ");
                        S = Console.ReadLine();
                        if (tree.Add_Lap_String(S))
                            Console.WriteLine("Đã thêm thành công.");
                        else
                            Console.WriteLine("Không thể thêm (giá trị đã tồn tại).");
                        break;

                    case 3:
                        Console.WriteLine("Duyệt cây theo PreOrder:");
                        tree.PreOrder(tree.root);
                        break;

                    case 4:
                        Console.WriteLine("Duyệt cây theo InOrder:");
                        tree.InOrder(tree.root);
                        break;

                    case 5:
                        Console.WriteLine("Duyệt cây theo PostOrder:");
                        tree.PostOrder(tree.root);
                        break;

                    case 6:
                        Console.WriteLine("Đã tạo cây từ mảng");
                        string[] arr = { "Chương", "Như_Võ", "Như_Ngô", "QTrang", "Duy_Khang", "Phương", "Nguyên" };
                        tree.CreateTreeString(arr);
                        break;

                    case 7:
                        Console.WriteLine("Tạo cây từ bàn phím.");
                        tree.CreateTreeString();
                        break;

                    case 8:
                        string chuoiDaiNhat = tree.FindMaxStringLength(tree.root);
                        Console.WriteLine($"Chuỗi dài nhất trong cây là: {chuoiDaiNhat}");
                        break;

                    case 9:
                        string chuoiNganNhat = tree.FindMinStringLength(tree.root);
                        Console.WriteLine($"Chuỗi dài nhất trong cây là: {chuoiNganNhat}");
                        break;

                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }
    }
}
