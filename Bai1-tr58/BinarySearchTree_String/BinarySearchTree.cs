using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_String
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        // Hiển thị khóa chuỗi
        public void DisplayString(Node node)
        {
            if (node != null)
                Console.Write($"{node.Value}      ");
            else
                Console.Write("null ");
        }

        // 1. Thêm nút bằng đệ quy
        public bool Add_DeQuy(ref Node aRoot, string S)
        {
            if (aRoot == null)
            {
                aRoot = new Node(S);
                return true;
            }
            int soSanhChuoi = string.Compare(S, aRoot.Value);
            if (soSanhChuoi < 0)
                return Add_DeQuy(ref aRoot.Left, S);
            else if (soSanhChuoi >= 0) // cho phép trùng lặp vào cây con phải, ko trùng thì bỏ dấu =
                return Add_DeQuy(ref aRoot.Right, S);
            else
                return false;
        }

        // 2. Thêm nút bằng pp lặp
        public bool Add_Lap_String(string S)
        {
            bool result = true;
            Node newNode = new Node(S);
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
                int cmp = string.Compare(S, curNode.Value);
                if (cmp < 0)
                {
                    curNode = curNode.Left;
                    if (curNode == null)
                    {
                        parentNode.Left = newNode;
                        return result;
                    }
                }
                else if (cmp > 0)
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
                    // Không thêm giá trị trùng lặp (nếu đề bài ko có giá trị trùng thì xài cái này)
                    //result = false;
                    //return result;

                    // Thêm giá trị trùng lặp vào cây con phải
                    curNode = curNode.Right;
                    if (curNode == null)
                    {
                        parentNode.Right = newNode;
                        return result;
                    }
                }
            }
        }

        public void Process(Node node)
        {
            DisplayString(node);
        }

        // 3. Duyệt cây theo thứ tự trước
        public void PreOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                Process(aRoot);
                PreOrder(aRoot.Left);
                PreOrder(aRoot.Right);
            }
        }

        // 4. Duyệt cây theo thứ tự giữa
        public void InOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                InOrder(aRoot.Left);
                Process(aRoot);
                InOrder(aRoot.Right);
            }
        }

        // 5. Duyệt cây theo thứ tự sau
        public void PostOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                PostOrder(aRoot.Left);
                PostOrder(aRoot.Right);
                Process(aRoot);
            }
        }

        // 6. Tạo cây từ mảng
        public void CreateTreeString(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //Add_Lap_String(arr[i]);
                Add_DeQuy(ref root, arr[i]);
            }
        }

        // 7. tạo cây từ bàn phím
        public void CreateTreeString()
        {
            Console.Write("Nhập số lượng nút: ");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập giá trị khóa thứ {i + 1}: ");
                arr[i] = Console.ReadLine();
            }
            CreateTreeString(arr);
        }

        // 8. Tìm chuỗi dài nhất theo độ dài
        public string FindMaxStringLength(Node aRoot)
        {
            if (aRoot == null) return null;
            string max = aRoot.Value;
            string left = FindMaxStringLength(aRoot.Left);
            string right = FindMaxStringLength(aRoot.Right);
            if (left != null && left.Length > max.Length)
                max = left;
            if (right != null && right.Length > max.Length)
                max = right;
            return max;
        }

        // 9. Tìm chuỗi ngắn nhất theo độ dài
        public string FindMinStringLength(Node aRoot)
        {
            if (aRoot == null) return null;
            string min = aRoot.Value;
            string left = FindMinStringLength(aRoot.Left);
            string right = FindMinStringLength(aRoot.Right);
            if (left != null && left.Length < min.Length)
                min = left;
            if (right != null && right.Length < min.Length)
                min = right;
            return min;
        }
    }
}
