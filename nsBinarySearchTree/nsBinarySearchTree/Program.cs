using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            BinarySearchTree tree = new BinarySearchTree();
            Console.Write("--- Cây tìm kiếm nhị phân ---");
            Console.Write("\nNhập số nút: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập giá trị khóa thứ {i + 1}: ");
                x = Convert.ToInt32(Console.ReadLine());
                tree.Add(x);
            }

            Console.Write("\n\nDuyệt thứ tự trước: \t");
            tree.PreOrder(tree.root);

            Console.Write("\nDuyệt thứ tự giữa: \t");
            tree.InOrder(tree.root);

            Console.Write("\nDuyệt thứ tự sau: \t");
            tree.PostOrder(tree.root);

            Console.Write($"\nChiều cao cây: {tree.CalTreeHeight(tree.root)}");
            Console.Write($"\nGiá trị nút Max: {tree.FindMax(tree.root)}");
            Console.Write($"\nGiá trị nút Min: {tree.FindMin(tree.root)}");

            int countAll = 0, sumAll = 0;
            tree.CountAndSumAllNodes(tree.root, ref countAll, ref sumAll);
            Console.Write($"\nGiá trị trung bình của tất cả các nút: {(float)sumAll / countAll}");
            Console.Write($"\n\nNhập giá trị nút muốn tìm: ");
            int X = Convert.ToInt32(Console.ReadLine());
            if (tree.Search(X) != null)
                Console.Write($"Nút {X} đã tìm thấy!");
            else
                Console.Write($"Nút {X} Không tìm thấy!");

            Console.Write("\nNhập giá trị muốn Hủy: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            tree.Remove(x1);

            Console.Write($"Duyệt thứ tự trước sau Hủy {x1}: \t");
            tree.PreOrder(tree.root);
            
            Console.Write("\nNhập giá trị muốn Hủy: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            tree.Remove(x2);

            Console.Write($"Duyệt thứ tự trước sau Hủy {x2}: \t");
            tree.PreOrder(tree.root);

            Console.Read();
        }
    }
}
