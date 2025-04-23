using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr58
{
    public class BinarySearch
    {
        public Node root;

        public BinarySearch()
        {
            root = null;
        }

        // 1.2.1 Hiển thị lên màn hình Khóa giá trị của 1 nút
        public void Display(Node node)
        {
            if (root != null)
                Console.Write($"{node.Key.ToString()} ");
            else
                Console.Write("null ");
        }

        public void Process(Node node)
        {
            Display(node);
        }

        // 1.2.2 Thêm nút có giá trị X vào cây dùng phương pháp đệ quy
        public bool Add_DeQuy(Node aRoot, int X)
        {
            if (aRoot == null)
            {
                aRoot = new Node(X);
                return true;
            }
            else if (X < aRoot.Key)
                return Add_DeQuy(aRoot.Left, X);
            else if (X > aRoot.Key)
                return Add_DeQuy(aRoot.Right, X);
            else
                return false;
        }

        // 1.2.3 Thêm nút có giá trị khóa X vào cây dùng phương pháp đệ quy
        public bool Add_Lap(int X)
        {
            bool result = true;
            Node newNode = new Node(X);
            if (root == null)
            {
                root = newNode;
                return result;
            }
            Node curNode = root;
            Node parentNode;
            while (true)
            {
                parentNode = curNode;
                if (X < curNode.Key)
                {
                    curNode = curNode.Left;
                    if (curNode == null)
                    {
                        parentNode.Left = newNode;
                        return result;
                    }
                }
                else if (X > curNode.Key)
                {
                    curNode = curNode.Right;
                    if (curNode == null)
                    {
                        parentNode.Right = newNode;
                        return result;
                    }
                }
                else
                {
                    result = false;
                    return result;
                }
            }
        }

        // 1.2.4 Duyệt cây theo thứ tự trước
        public void PreOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                Process(aRoot);
                PreOrder(aRoot.Left);
                PreOrder(aRoot.Right);
            }
        }

        // 1.2.5 Duyệt cây theo thứ tự giữa
        public void InOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                Process(aRoot.Left);
                Process(aRoot);
                InOrder(aRoot.Right);
            }
        }

        // 1.2.6 Duyệt cây theo thứ tự sau
        public void PostOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                PostOrder(aRoot.Left);
                PostOrder(aRoot.Right);
                Process(aRoot);
            }
        }

        // 1.2.7 Tạo cây từ các số lấy từ mảng số nguyên
        public void CreateTree(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //Add_Lap(arr[i]);
                Add_DeQuy(root, arr[i]);
            }
        }

        // 1.2.8 Tạo cây từ các số nhập từ bàn phím
        public void CreateTree()
        {
            Console.Write("Nhập số lượng nút: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhập các giá trị nút:");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            CreateTree(arr);
        }

        // 1.2.9 Tìm kiếm nút có giá trị X trong cây dùng phương pháp đệ quy
        public Node Search(Node aRoot, int X)
        {
            if (aRoot == null)
                return null;
            if (X < aRoot.Key)
                return Search(aRoot.Left, X);
            else if (X > aRoot.Key)
                return Search(aRoot.Right, X);
            else
                return aRoot;
        }

        // 1.2.10 Tìm kiếm nút có giá trị X trong cây dùng phương pháp lặp
        public Node Search(int X)
        {
            Node curNode = root;
            while (X != curNode.Key)
            {
                if (X < curNode.Key)
                    curNode = curNode.Left;
                else
                    curNode = curNode.Right;
                if (curNode == null)
                    return null;
            }
            return curNode;
        }

        // 1.2.11 Tìm nút lớn nhất của cây
        public int FindMax(Node aRoot)
        {
            int Max = aRoot.Key;
            if (aRoot.Right == null)
                return Max;
            else
                return FindMax(aRoot.Right);
        }

        // 1.2.12 Tìm nút nhỏ nhất của cây
        public int FindMin(Node aRoot)
        {
            int Min = aRoot.Key;
            if (aRoot.Left == null)
                return Min;
            else
                return FindMin(aRoot.Left);
        }
    }
}
