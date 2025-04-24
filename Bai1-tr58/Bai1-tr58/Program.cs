using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr58
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            BinarySearch tree = new BinarySearch();
            int choice, x;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Hiển thị giá trị khóa của một nút");
                Console.WriteLine("2. Thêm nút (đệ quy)");
                Console.WriteLine("3. Thêm nút (lặp)");
                Console.WriteLine("4. Duyệt cây PreOrder");
                Console.WriteLine("5. Duyệt cây InOrder");
                Console.WriteLine("6. Duyệt cây PostOrder");
                Console.WriteLine("7. Tạo cây từ mảng");
                Console.WriteLine("8. Tạo cây từ bàn phím");
                Console.WriteLine("9. Tìm nút (đệ quy)");
                Console.WriteLine("10. Tìm nút (lặp)");
                Console.WriteLine("11. Tìm nút lớn nhất");
                Console.WriteLine("12. Tìm nút nhỏ nhất");
                Console.WriteLine("13. Tìm nút >= X gần nhất");
                Console.WriteLine("14. Tìm nút <= X gần nhất");
                Console.WriteLine("15. Đếm số nút");
                Console.WriteLine("16. Đếm nút lá");
                Console.WriteLine("17. Đếm nút lẻ");
                Console.WriteLine("18. Đếm nút dương");
                Console.WriteLine("19. Đếm nút có đúng 1 con");
                Console.WriteLine("20. Tổng tất cả nút");
                Console.WriteLine("21. Tổng nút lá");
                Console.WriteLine("22. Mức của nút X");
                Console.WriteLine("23. Chiều cao của cây");
                Console.WriteLine("24. Xóa nút X (đệ quy)");
                Console.WriteLine("25. Xóa nút X (lặp)");
                Console.WriteLine("0. Thoát");
                Console.Write("\nChọn chức năng: ");
                choice = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập giá trị khóa nút cần hiển thị: ");
                        x = int.Parse(Console.ReadLine());
                        Node node = tree.Search(tree.root, x);
                        tree.Display(node);
                        break;

                    case 2:
                        Console.Write("Nhập giá trị X để thêm (đệ quy): ");
                        x = int.Parse(Console.ReadLine());
                        if (tree.Add_DeQuy(tree.root, x))
                            Console.WriteLine("Đã thêm thành công.");
                        else
                            Console.WriteLine("Không thể thêm (giá trị đã tồn tại).");
                        break;

                    case 3:
                        Console.Write("Nhập giá trị X để thêm (lặp): ");
                        x = int.Parse(Console.ReadLine());
                        if (tree.Add_Lap(x))
                            Console.WriteLine("Đã thêm thành công.");
                        else
                            Console.WriteLine("Không thể thêm (giá trị đã tồn tại).");
                        break;

                    case 4:
                        Console.WriteLine("Duyệt cây theo PreOrder:");
                        tree.PreOrder(tree.root);
                        break;

                    case 5:
                        Console.WriteLine("Duyệt cây theo InOrder:");
                        tree.InOrder(tree.root);
                        break;

                    case 6:
                        Console.WriteLine("Duyệt cây theo PostOrder:");
                        tree.PostOrder(tree.root);
                        break;

                    case 7:
                        Console.WriteLine("Nhập các giá trị từ mảng để tạo cây:");
                        int[] arr = { 5, 3, 8, 1, 4, 7, 9 };
                        tree.CreateTree(arr);
                        break;

                    case 8:
                        Console.WriteLine("Tạo cây từ bàn phím.");
                        tree.CreateTree();
                        break;

                    case 9:
                        Console.Write("Nhập giá trị khóa X để tìm (đệ quy): ");
                        x = int.Parse(Console.ReadLine());
                        node = tree.Search(tree.root, x);
                        tree.Display(node);
                        break;

                    case 10:
                        Console.Write("Nhập giá trị khóa X để tìm (lặp): ");
                        x = int.Parse(Console.ReadLine());
                        node = tree.Search(x);
                        tree.Display(node);
                        break;

                    case 11:
                        Console.WriteLine("Nút lớn nhất: " + tree.FindMax(tree.root));
                        break;

                    case 12:
                        Console.WriteLine("Nút nhỏ nhất: " + tree.FindMin(tree.root));
                        break;

                    case 13:
                        Console.Write("Nhập giá trị X để tìm nút >= X gần nhất: ");
                        x = int.Parse(Console.ReadLine());
                        node = tree.FindMinGreaterThanOrEqualX(tree.root, x);
                        tree.Display(node);
                        break;

                    case 14:
                        Console.Write("Nhập giá trị X để tìm nút <= X gần nhất: ");
                        x = int.Parse(Console.ReadLine());
                        node = tree.FindMaxLessThanOrEquals(tree.root, x);
                        tree.Display(node);
                        break;

                    case 15:
                        Console.WriteLine("Số nút trong cây: " + tree.CountNodes(tree.root));
                        break;

                    case 16:
                        Console.WriteLine("Số nút lá trong cây: " + tree.CountLeafNodes(tree.root));
                        break;

                    case 17:
                        Console.WriteLine("Số nút lẻ trong cây: " + tree.CountOddNodes(tree.root));
                        break;

                    case 18:
                        Console.WriteLine("Số nút dương trong cây: " + tree.CountPositiveNodes(tree.root));
                        break;

                    case 19:
                        Console.WriteLine("Số nút có đúng một con: " + tree.CountNodesWithOneChild(tree.root));
                        break;

                    case 20:
                        Console.WriteLine("Tổng giá trị khóa của tất cả nút: " + tree.SumAllNodes(tree.root));
                        break;

                    case 21:
                        Console.WriteLine("Tổng giá trị khóa các nút lá: " + tree.SumLeafNodes(tree.root));
                        break;

                    case 22:
                        Console.Write("Nhập giá trị X để xác định mức: ");
                        x = int.Parse(Console.ReadLine());
                        int level = tree.GetLevel(tree.root, x);
                        Console.WriteLine("Mức của nút X: " + level);
                        break;

                    case 23:
                        Console.WriteLine("Chiều cao của cây: " + tree.Height(tree.root));
                        break;

                    case 24:
                        Console.Write("Nhập giá trị X để xóa (đệ quy): ");
                        x = int.Parse(Console.ReadLine());
                        tree.DeleteNode_Recursion(tree.root, x);
                        Console.WriteLine("Đã xóa thành công (đệ quy).");
                        break;

                    case 25:
                        Console.Write("Nhập giá trị X để xóa (lặp): ");
                        x = int.Parse(Console.ReadLine());
                        tree.DeleteNode_Iteration(x);
                        Console.WriteLine("Đã xóa thành công (lặp).");
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
