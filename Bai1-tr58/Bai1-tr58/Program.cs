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

            BinarySearchTree tree = new BinarySearchTree();
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
                Console.WriteLine("141. Tìm nút <= X gần nhất");
                Console.WriteLine("142. Tìm nút là số nguyên tố");
                Console.WriteLine("143. Tìm nút cha");
                Console.WriteLine("144. Tìm nút con");
                Console.WriteLine("15. Đếm số nút");
                Console.WriteLine("161. Đếm nút lá");
                Console.WriteLine("162. Đếm số lần xuất hiện của các giá trị khóa trong cây");
                Console.WriteLine("171. Đếm nút lẻ");
                Console.WriteLine("172. Đếm nút chẵn");
                Console.WriteLine("181. Đếm nút dương");
                Console.WriteLine("182. Đếm nút âm");
                Console.WriteLine("191. Đếm nút có đúng 1 con");
                Console.WriteLine("192. Đếm nút có đúng 2 con");
                Console.WriteLine("193. Đếm nút có đúng 1 con và đúng 2 con");
                Console.WriteLine("20. Tổng tất cả nút");
                Console.WriteLine("211. Tổng nút lá");
                Console.WriteLine("212. Tổng nút chẵn");
                Console.WriteLine("213. Tổng nút lẻ");
                Console.WriteLine("214. Tổng nút là Số nguyên tố");
                Console.WriteLine("22. Mức của nút X");
                Console.WriteLine("23. Chiều cao của cây");
                Console.WriteLine("24. Xóa nút X (đệ quy)");
                Console.WriteLine("251. Xóa nút X (lặp)");
                Console.WriteLine("252. Xóa tất cả các nút có giá trị khóa là số nguyên tố");
                Console.WriteLine("26. Tìm nút trung gian có trong cây");
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
                        Console.WriteLine("Đã tạo cây từ mảng");
                        int[] arr = { 10, 6, 15, 12, 9, 12, 26, 14, 56, 35 };
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
                        node = tree.FindMinGreaterThanOrEquals(tree.root, x);
                        tree.Display(node);
                        break;

                    case 141:
                        Console.Write("Nhập giá trị X để tìm nút <= X gần nhất: ");
                        x = int.Parse(Console.ReadLine());
                        node = tree.FindMaxLessThanOrEquals(tree.root, x);
                        tree.Display(node);
                        break;

                    case 142:
                        node = tree.FindPrimeNode(tree.root);
                        tree.Display(node);
                        break;

                    case 143:
                        Console.Write("Nhập giá trị X để tìm nút cha: ");
                        x = int.Parse(Console.ReadLine());
                        node = tree.FindParent(tree.root, x);
                        tree.Display(node);
                        break;

                    case 144:
                        Console.Write("Nhập giá trị X để tìm nút con: ");
                        x = int.Parse(Console.ReadLine());
                        node = tree.FindChild(tree.root, x);

                        // Kiểm tra và hiển thị thông tin của nút con
                        if (node != null)
                        {
                            Console.Write($"\nNút con có giá trị {x}: ");
                            tree.Display(node);

                            // In trái và phải của nút con
                            Console.Write("\nTrái: ");
                            tree.Display(node.Left);
                            Console.Write("| Phải: ");
                            tree.Display(node.Right);
                        }
                        else
                            Console.WriteLine("Không tìm thấy nút con có giá trị " + x);
                        break;

                    case 15:
                        Console.WriteLine("Số nút trong cây: " + tree.CountNodes(tree.root));
                        break;

                    case 161:
                        Console.WriteLine("Số nút lá trong cây: " + tree.CountLeafNodes(tree.root));
                        break;

                    case 162:
                        Console.Write("Nhập giá trị khóa để đếm số lần xuất hiện: ");
                        x = int.Parse(Console.ReadLine());
                        int count = tree.CountOccurrences(tree.root, x);
                        Console.WriteLine("Số lần xuất hiện của " + x + ": " + count);
                        break;

                    case 171:
                        Console.WriteLine("Số nút lẻ trong cây: " + tree.CountOddNodes(tree.root));
                        break;

                    case 172:
                        Console.WriteLine("Số nút chẵn trong cây: " + tree.CountEvenNodes(tree.root));
                        break;

                    case 181:
                        Console.WriteLine("Số nút dương trong cây: " + tree.CountPositiveNodes(tree.root));
                        break;

                    case 182:
                        Console.WriteLine("Số nút âm trong cây: " + tree.CountNegativeNodes(tree.root));
                        break;

                    case 191:
                        Console.WriteLine("Số nút có đúng một con: " + tree.CountNodesWithOneChild(tree.root));
                        break;

                    case 192:
                        Console.WriteLine("Số nút có đúng hai con: " + tree.CountNodesWithTwoChildren(tree.root));
                        break;

                    case 193:
                        Console.WriteLine("Số nút có đúng một con và đúng hai con: " + tree.CountNodesWithOneOrTwoChildren(tree.root));
                        break;

                    case 20:
                        Console.WriteLine("Tổng giá trị khóa của tất cả nút: " + tree.SumAllNodes(tree.root));
                        break;

                    case 211:
                        Console.WriteLine("Tổng giá trị khóa các nút lá: " + tree.SumLeafNodes(tree.root));
                        break;

                    case 212:
                        Console.WriteLine("Tổng giá trị khóa các nút chẵn: " + tree.SumEvenNodes(tree.root));
                        break;

                    case 213:
                        Console.WriteLine("Tổng giá trị khóa các nút lẻ: " + tree.SumOddNodes(tree.root));
                        break;

                    case 214:
                        Console.WriteLine("Tổng giá trị khóa các nút là số nguyên tố: " + tree.SumPrimeNodes(tree.root));
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

                    case 251:
                        Console.Write("Nhập giá trị X để xóa (lặp): ");
                        x = int.Parse(Console.ReadLine());
                        tree.DeleteNode_Iteration(x);
                        Console.WriteLine("Đã xóa thành công (lặp).");
                        break;

                    case 252:
                        Console.WriteLine("Xóa tất cả các nút có giá trị khóa là số nguyên tố.");
                        tree.DeletePrimeNodes(tree.root);
                        Console.WriteLine("Đã xóa thành công.");
                        break;

                    case 26:
                        Console.Write("Nhập giá trị X để tìm nút trung gian: ");
                        x = int.Parse(Console.ReadLine());
                        node = tree.FindMiddleNodeHelper(tree.root, ref x);
                        tree.Display(node);
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
