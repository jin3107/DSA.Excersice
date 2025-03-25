using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr24
{
    public class Search
    {
        // 1.1. Tìm phần từ có giá trị X đầu tiên
        public int FindFirst(int[] arr, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        // 1.2. Tìm phần tử có giá trị X cuối cùng
        public int FindLast(int[] arr, int n, int x)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        // 1.3. Tìm tất cả phần tử có giá trị X
        public List<int> FindAll(int[] arr, int n, int x)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    indices.Add(i);
            }
            return indices;
        }

        // 1.4. Tìm phần tử nhỏ nhất đầu tiên
        public int FindMinFirst(int[] arr, int n)
        {
            int imin = 0;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[imin])
                    imin = i;
            }
            return imin;
        }

        // 1.5. Tìm phần tử lớn nhất sau cùng
        public int FindMaxLast(int[] arr, int n)
        {
            int imax = n - 1;
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > arr[imax])
                    imax = i;
            }
            return imax;
        }

        // 1.6. Tìm tất cả các số nhỏ nhất trong mảng
        public List<int> FindAllMin(int[] arr, int n)
        {
            List<int> indices = new List<int>();
            int min = int.MaxValue;
            foreach (var num in arr)
            {
                if (num < min)
                    min = num;
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == min)
                    indices.Add(i);
            }
            return indices;
        }

        // 1.7. Tìm phần tử là số lẻ lớn nhất đầu tiên
        public int FindFirstMaxOdd(int[] arr, int n)
        {
            int maxOdd = int.MinValue, index = -1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] > maxOdd)
                {
                    maxOdd = arr[i];
                    index = i;
                }
            }
            return index;
        }

        // 1.8. Tìm kiếm phần tử là số chẵn lớn nhất sau cùng
        public int FindLastMaxEven(int[] arr, int n)
        {
            int maxEven = int.MinValue, index = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == 0 && arr[i] > maxEven)
                {
                    maxEven = arr[i];
                    index = i;
                }
            }
            return index;
        }

        // 1.9. Tìm kiếm nhị phân phần tử có giá trị X (phương pháp lặp)
        public int BinarySearchInterative(int[] arr, int n, int x)
        {
            QuickSortIterative(arr, 0, n - 1);
            int low = 0, up = n - 1;
            while (low <= up)
            {
                int mid = (low + up) / 2;
                if (arr[mid] == x)
                    return mid;
                else if (x > arr[mid])
                    low = mid + 1;
                else
                    up = mid - 1;
            }
            return -1;
        }

        public void QuickSortIterative(int[] arr, int left, int right)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(left);
            stack.Push(right);
            while (stack.Count > 0)
            {
                right = stack.Pop();
                left = stack.Pop();
                int pivotIndex = Partition(arr, left, right);
                if (left < pivotIndex - 1) { stack.Push(left); stack.Push(pivotIndex - 1); }
                if (pivotIndex + 1 < right) { stack.Push(pivotIndex + 1); stack.Push(right); }
            }
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            Swap(ref arr[i + 1], ref arr[right]);
            return i + 1;
        }

        // 1.10. Tìm kiếm nhị phân phần tử có giá trị X (phương pháp đệ quy)
        public int BinarySearchRecursive(int[] arr, int low, int up, int x)
        {
            QuickSortRecursive(arr, low, up);
            if (low > up)
                return -1;
            int mid = (low + up) / 2;
            if (arr[mid] == x)
                return mid;
            else if (x < arr[mid])
                return BinarySearchRecursive(arr, low, mid - 1, x);
            else
                return BinarySearchRecursive(arr, mid + 1, up, x);
        }

        public void QuickSortRecursive(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = arr[left];
                int i = left, j = right;
                while (i <= j)
                {
                    while (arr[i] < pivot) i++;
                    while (arr[j] > pivot) j--;
                    if (i <= j)
                    {
                        Swap(ref arr[i], ref arr[j]);
                        i++;
                        j--;
                    }
                }
                QuickSortRecursive(arr, left, j);
                QuickSortRecursive(arr, i, right);
            }
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
