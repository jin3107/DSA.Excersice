using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr58
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        // 1. Hiển thị lên màn hình Khóa giá trị của 1 nút
        public void Display(Node node)
        {
            if (node != null)
                Console.Write($"{node.Key.ToString()} ");
            else
                Console.Write("null ");
        }

        public void Process(Node node)
        {
            Display(node);
        }

        // 2. Thêm nút có giá trị X vào cây dùng phương pháp đệ quy
        public bool Add_DeQuy(ref Node aRoot, int X)
        {
            if (aRoot == null)
            {
                aRoot = new Node(X);
                return true;
            }
            else if (X < aRoot.Key)
                return Add_DeQuy(ref aRoot.Left, X);
            else if (X >= aRoot.Key) // cho phép trùng lặp vào cây con phải, ko trùng thì bỏ dấu = 
                return Add_DeQuy(ref aRoot.Right, X);
            else
                return false;
        }

        // 3. Thêm nút có giá trị khóa X vào cây dùng phương pháp lặp
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
                    // Không thêm giá trị trùng lặp (nếu đề bài ko có giá trị trùng thì xài cái này)
                    //result = false;
                    //return result;

                    // Thêm giá trị trùng lặp vào cây con phải (hoặc cây con trái tùy ý)
                    curNode = curNode.Right;
                    if (curNode == null)
                    {
                        parentNode.Right = newNode;
                        return result;
                    }
                }
            }
        }

        // 4. Duyệt cây theo thứ tự trước
        public void PreOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                Process(aRoot);
                PreOrder(aRoot.Left);
                PreOrder(aRoot.Right);
            }
        }

        // 5. Duyệt cây theo thứ tự giữa
        public void InOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                InOrder(aRoot.Left);
                Process(aRoot);
                InOrder(aRoot.Right);
            }
        }

        // 6. Duyệt cây theo thứ tự sau
        public void PostOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                PostOrder(aRoot.Left);
                PostOrder(aRoot.Right);
                Process(aRoot);
            }
        }

        // 7. Tạo cây từ các số lấy từ mảng số nguyên
        public void CreateTree(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                //Add_Lap(arr[i]);
                Add_DeQuy(ref root, arr[i]);
            }
        }

        // 8. Tạo cây từ các số nhập từ bàn phím
        public void CreateTree()
        {
            Console.Write("Nhập số lượng nút: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập giá trị khóa thứ {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            CreateTree(arr);
        }

        // 9. Tìm kiếm nút có giá trị X trong cây dùng phương pháp đệ quy
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

        // 10. Tìm kiếm nút có giá trị X trong cây dùng phương pháp lặp
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

        // 11. Tìm nút lớn nhất của cây
        public int FindMax(Node aRoot)
        {
            int Max = aRoot.Key;
            if (aRoot.Right == null)
                return Max;
            else
                return FindMax(aRoot.Right);
        }

        // 12. Tìm nút nhỏ nhất của cây
        public int FindMin(Node aRoot)
        {
            int Min = aRoot.Key;
            if (aRoot.Left == null)
                return Min;
            else
                return FindMin(aRoot.Left);
        }

        // 13. Tìm nút lớn hơn và gần bằng nhất với nút khóa X
        public Node FindMinGreaterThanOrEquals(Node aRoot, int X)
        {
            if (aRoot == null)
                return null;
            if (aRoot.Key < X)
                return FindMinGreaterThanOrEquals(aRoot.Right, X);
            Node leftNode = FindMinGreaterThanOrEquals(aRoot.Left, X);
            if (leftNode != null)
                return leftNode;
            else
                return aRoot;
        }

        // 14. Tìm nút nhỏ hơn và gần bằng nhất với nút khóa X
        public Node FindMaxLessThanOrEquals(Node aRoot, int X)
        {
            if (aRoot == null)
                return null;
            if (aRoot.Key > X)
                return FindMaxLessThanOrEquals(aRoot.Left, X);
            Node rightNode = FindMaxLessThanOrEquals(aRoot.Right, X);
            if (rightNode != null)
                return rightNode;
            else
                return aRoot;
        }

        // 15. Tìm nút là số nguyên tố 
        public Node FindPrimeNode(Node aRoot)
        {
            if (aRoot == null) return null;
            if (IsPrime(aRoot.Key)) return aRoot;
            Node leftNode = FindPrimeNode(aRoot.Left);
            if (leftNode != null) return leftNode;
            return FindPrimeNode(aRoot.Right);
        }

        // 16. Tìm kiếm nút cha có giá trị X (FindParent)
        public Node FindParent(Node aRoot, int X)
        {
            if (aRoot == null || (aRoot.Left == null && aRoot.Right == null)) return null;
            if ((aRoot.Left != null && aRoot.Left.Key == X) || (aRoot.Right != null && aRoot.Right.Key == X))
                return aRoot;
            Node leftParent = FindParent(aRoot.Left, X);
            if (leftParent != null) return leftParent;
            return FindParent(aRoot.Right, X);
        }

        // 17. Tìm kiếm nút con có giá trị X (FindChild)
        public Node FindChild(Node aRoot, int X)
        {
            if (aRoot == null) return null;
            if (aRoot.Key == X) return aRoot;
            Node leftChild = FindChild(aRoot.Left, X);
            if (leftChild != null) return leftChild;
            return FindChild(aRoot.Right, X);
        }

        // 18. Đếm số nút trong cây
        public int CountNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            return 1 + CountNodes(aRoot.Left) + CountNodes(aRoot.Right);
        }

        // 19. Đếm số nút lá
        public int CountLeafNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            if (aRoot.Right == null && aRoot.Left == null) return 1;
            return CountLeafNodes(aRoot.Left) + CountLeafNodes(aRoot.Right);
        }

        // 20. Đếm số lần xuất hiện của các giá trị khóa trong cây
        public int CountOccurrences(Node aRoot, int X)
        {
            if (aRoot == null) return 0;
            int count = 0;
            if (aRoot.Key == X)
                count = 1;
            return count + CountOccurrences(aRoot.Left, X) + CountOccurrences(aRoot.Right, X);
        }

        // 21. Đếm số nút lẻ
        public int CountOddNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            int count = 0;
            if (aRoot.Key % 2 != 0)
                count = 1;
            return count + CountOddNodes(aRoot.Left) + CountOddNodes(aRoot.Right);
        }

        // 22. Đếm số nút chẵn
        public int CountEvenNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            int count = 0;
            if (aRoot.Key % 2 == 0)
                count = 1;
            return count + CountEvenNodes(aRoot.Left) + CountEvenNodes(aRoot.Right);
        }

        // 23. Đếm số nút dương
        public int CountPositiveNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            int count = 0;
            if (aRoot.Key > 0)
                count = 1;
            return count + CountPositiveNodes(aRoot.Left) + CountPositiveNodes(aRoot.Right);
        }

        // 24. Đếm số nút âm
        public int CountNegativeNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            int count = 0;
            if (aRoot.Key < 0)
                count = 1;
            return count + CountNegativeNodes(aRoot.Left) + CountNegativeNodes(aRoot.Right);
        }

        // 25. Đếm số nút có đúng 1 nút con
        public int CountNodesWithOneChild(Node aRoot)
        {
            if (aRoot == null) return 0;
            int count = 0;
            if (aRoot.Left == null && aRoot.Right != null)
                count = 1;
            else if (aRoot.Left != null && aRoot.Right == null)
                count = 1;
            return count + CountNodesWithOneChild(aRoot.Left) + CountNodesWithOneChild(aRoot.Right);
        }

        // 26. Đếm số nút có đúng 2 con
        public int CountNodesWithTwoChildren(Node aRoot)
        {
            if (aRoot == null) return 0;
            int count = 0;
            if (aRoot.Left != null && aRoot.Right != null)
                count = 1;
            return count + CountNodesWithTwoChildren(aRoot.Left) + CountNodesWithTwoChildren(aRoot.Right);
        }

        // 27. Đếm số nút có đúng 1 con và nút có đúng 2 con
        public int CountNodesWithOneOrTwoChildren(Node aRoot)
        {
            if (aRoot == null) return 0;
            int count = 0;
            if ((aRoot.Left == null && aRoot.Right != null) || (aRoot.Left != null && aRoot.Right == null) || (aRoot.Left != null && aRoot.Right != null))
                count = 1;
            return count + CountNodesWithOneOrTwoChildren(aRoot.Left) + CountNodesWithOneOrTwoChildren(aRoot.Right);
        }

        // 28. Tính giá trị khóa các nút trong cây
        public int SumAllNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            return aRoot.Key + SumAllNodes(aRoot.Left) + SumAllNodes(aRoot.Right);
        }

        // 29. Tính tổng giá trị khóa các nút lá
        public int SumLeafNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            if (aRoot.Left == null && aRoot.Right == null) return aRoot.Key;
            return SumLeafNodes(aRoot.Left) + SumLeafNodes(aRoot.Right);
        }

        // 30. Tính tổng giá trị khóa các nút chẵn
        public int SumEvenNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            int sum = 0;
            if (aRoot.Key % 2 == 0)
                sum = aRoot.Key;
            return sum + SumEvenNodes(aRoot.Left) + SumEvenNodes(aRoot.Right);
        }

        // 31. Tính tổng giá trị khóa các nút lẻ
        public int SumOddNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            int sum = 0;
            if (aRoot.Key % 2 != 0)
                sum = aRoot.Key;
            return sum + SumOddNodes(aRoot.Left) + SumOddNodes(aRoot.Right);
        }

        // 32. Tính tổng giá trị khóa các nút là số nguyên tố
        public int SumPrimeNodes(Node aRoot)
        {
            if (aRoot == null) return 0;
            int sum = 0;
            if (IsPrime(aRoot.Key))
                sum = aRoot.Key;
            return sum + SumPrimeNodes(aRoot.Left) + SumPrimeNodes(aRoot.Right);
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // 33. Xác định mức của một nút trong cây
        public int GetLevel(Node aRoot, int X, int level = 0)
        {
            if (aRoot == null) return -1;
            if (aRoot.Key == X) return level;
            int leftLevel = GetLevel(aRoot.Left, X, level + 1);
            if (leftLevel != -1) return leftLevel;
            return GetLevel(aRoot.Right, X, level + 1);
        }

        // 34. Xác định chiều cao của cây
        public int Height(Node aRoot)
        {
            if (aRoot == null) return -1;
            return 1 + Math.Max(Height(aRoot.Left), Height(aRoot.Right));
        }

        // 35. Xóa nút có giá trị X trong cây dùng phương pháp đệ quy
        public Node DeleteNode_Recursion(Node aRoot, int X)
        {
            if (aRoot == null) return null;
            if (X < aRoot.Key)
                aRoot.Left = DeleteNode_Recursion(aRoot.Left, X);
            else if (X > aRoot.Key)
                aRoot.Right = DeleteNode_Recursion(aRoot.Right, X);
            else
            {
                if (aRoot.Left == null) return aRoot.Right;
                if (aRoot.Right == null) return aRoot.Left;
                aRoot.Key = FindMin(aRoot.Right);
                aRoot.Right = DeleteNode_Recursion(aRoot.Right, aRoot.Key);
            }
            return aRoot;
        }

        // 36, Xóa nút có giá trị X trong cây dùng phương pháp lặp
        public void DeleteNode_Iteration(int X)
        {
            Node parent = null, current = root;
            while (current != null && current.Key != X)
            {
                parent = current;
                if (X < current.Key)
                    current = current.Left;
                else
                    current = current.Right;
            }
            if (current == null) return;

            // TH1: Không có con hoặc chỉ có 1 con
            Node child;
            if (current.Left != null)
                child = current.Left;
            else
                child = current.Right;

            if (parent == null)
                root = child;
            else if (parent.Left == current)
                parent.Left = child;
            else
                parent.Right = child;

            // TH2: Có 2 con
            if (current.Left != null && current.Right != null)
            {
                Node minParent = current;
                Node min = current.Right;
                while (min.Left != null)
                {
                    minParent = min;
                    min = min.Left;
                }
                current.Key = min.Key;
                if (minParent.Left == min)
                    minParent.Left = min.Right;
                else
                    minParent.Right = min.Right;
            }
        }

        // 37. Xóa tất cả các nút có giá trị khóa là số nguyên tố
        public void DeletePrimeNodes(Node aRoot)
        {
            if (aRoot == null) return;
            if (IsPrime(aRoot.Key))
                aRoot = DeleteNode_Recursion(aRoot, aRoot.Key);
            else
            {
                DeletePrimeNodes(aRoot.Left);
                DeletePrimeNodes(aRoot.Right);
            }
        }
    }
}