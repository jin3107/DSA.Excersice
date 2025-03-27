using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_tr25
{
    public class Search
    {
        public void MeasureTime(string algorithm, Action sortMethod)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sortMethod();
            stopwatch.Stop();
            Console.WriteLine($"{algorithm} chạy trong {stopwatch.ElapsedMilliseconds} ms\n");
        }

        public int SeqSearch(int[] arr, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        public int BinarySearchInterative(int[] arr, int n, int x)
        {
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

        public int BinarySearchRecursive(int[] arr, int low, int up, int x)
        {
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
